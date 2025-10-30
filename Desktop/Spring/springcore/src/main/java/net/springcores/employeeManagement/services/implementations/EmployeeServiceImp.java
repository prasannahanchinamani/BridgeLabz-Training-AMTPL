package net.springcores.employeeManagement.services.implementations;

import jakarta.transaction.Transactional;
import lombok.RequiredArgsConstructor;
import net.springcores.employeeManagement.dto.EmployeeDTO;
import net.springcores.employeeManagement.dto.EmployeeMapper;
import net.springcores.employeeManagement.entities.Employee;
import net.springcores.employeeManagement.entities.Project;
import net.springcores.employeeManagement.exceptions.ResourceNotFoundException;
import net.springcores.employeeManagement.repository.EmployeeRepository;
import net.springcores.employeeManagement.repository.ProjectRepository;
import net.springcores.employeeManagement.services.EmployeeService;
import org.springframework.stereotype.Service;

import java.util.HashSet;
import java.util.List;
import java.util.Set;
import java.util.stream.Collectors;

@Service
@Transactional
@RequiredArgsConstructor
public class EmployeeServiceImp implements EmployeeService {
    private final EmployeeRepository employeeRepository;
    private final ProjectRepository projectRepository;

    @Override
    public EmployeeDTO createEmployee(EmployeeDTO employeeDTO) {
        Set<Project> projects = new HashSet<>();
        if (employeeDTO.getProjectIds() != null) {
            projects = new HashSet<>(projectRepository.findAllById(employeeDTO.getProjectIds()));
        }
        Employee employee = EmployeeMapper.toEntity(employeeDTO, projects);
        Employee saved = employeeRepository.save(employee);
        return EmployeeMapper.toDTO(saved);
    }

    @Override
    public EmployeeDTO getEmployeeById(int id) {
        Employee employee = employeeRepository.findById(id)
                .orElseThrow(() -> new ResourceNotFoundException("Employee not found with id: " + id));
        return EmployeeMapper.toDTO(employee);
    }

    @Override
    public List<EmployeeDTO> getAllEmployees() {
        return employeeRepository.findAll()
                .stream()
                .map(EmployeeMapper::toDTO)
                .collect(Collectors.toList());
    }

    @Override
    public EmployeeDTO updateEmployee(int id, EmployeeDTO employeeDTO) {
        Employee existingEmployee = employeeRepository.findById(id)
                .orElseThrow(() -> new ResourceNotFoundException("Employee not found with id: " + id));

        existingEmployee.setName(employeeDTO.getName());
        existingEmployee.setEmail(employeeDTO.getEmail());
        existingEmployee.setDepartment(employeeDTO.getDepartment());

        if (employeeDTO.getProjectIds() != null) {
            Set<Project> projects = new HashSet<>(projectRepository.findAllById(employeeDTO.getProjectIds()));
            existingEmployee.setProjects(projects);
        }


        Employee updated = employeeRepository.save(existingEmployee);
        return EmployeeMapper.toDTO(updated);
    }

    @Override
    public void deleteEmployee(int id) {
        if (!employeeRepository.existsById(id)) {
            throw new ResourceNotFoundException("Employee not found with id: " + id);
        }
        employeeRepository.deleteById(id);
    }
}
