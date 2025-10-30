package net.springcores.employeeManagement.dto;

import jakarta.validation.constraints.Email;
import jakarta.validation.constraints.NotBlank;
import lombok.Data;

import java.util.Set;

@Data
public class EmployeeDTO {

    private int id;

    @NotBlank(message = "Employee name is required")
    private String name;

    @Email(message = "Invalid email")
    private String email;

    @NotBlank(message = "Department is required")
    private String department;

    private Set<Integer> projectIds;
}
