package net.springcores.employeeManagement.dto;

import net.springcores.employeeManagement.entities.Employee;
import net.springcores.employeeManagement.entities.Project;
import org.springframework.stereotype.Component;

import java.util.HashSet;
import java.util.Set;

@Component
public class EmployeeMapper {

    //  DTO → Entity
    public static Employee toEntity(EmployeeDTO dto, Set<Project> projects) {
        Employee employee = new Employee();


        if (dto.getId() > 0) {
            employee.setId(dto.getId());
        }

        employee.setName(dto.getName());
        employee.setEmail(dto.getEmail());
        employee.setDepartment(dto.getDepartment());
        employee.setProjects(projects != null ? projects : new HashSet<>());
        return employee;
    }

    //  Entity → DTO
    public static EmployeeDTO toDTO(Employee employee) {
        EmployeeDTO dto = new EmployeeDTO();
        dto.setId(employee.getId());
        dto.setName(employee.getName());
        dto.setEmail(employee.getEmail());
        dto.setDepartment(employee.getDepartment());

        Set<Integer> projectIds = new HashSet<>();
        employee.getProjects().forEach(p -> projectIds.add(p.getId()));
        dto.setProjectIds(projectIds);

        return dto;
    }
}
