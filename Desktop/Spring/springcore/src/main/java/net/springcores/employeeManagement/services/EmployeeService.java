package net.springcores.employeeManagement.services;

import net.springcores.employeeManagement.dto.EmployeeDTO;
import java.util.List;

public interface EmployeeService {
    EmployeeDTO createEmployee(EmployeeDTO employeeDTO);
    EmployeeDTO getEmployeeById(int id);
    List<EmployeeDTO> getAllEmployees();
    EmployeeDTO updateEmployee(int id, EmployeeDTO employeeDTO);
    void deleteEmployee(int id);
}

