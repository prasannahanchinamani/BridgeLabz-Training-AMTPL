package net.springcores.employeeManagement.dto;

import jakarta.validation.constraints.Min;
import jakarta.validation.constraints.NotBlank;
import lombok.Data;

@Data
public class ProjectDTO {

    private int id;

    @NotBlank(message = "Project name is required")
    private String name;

    @Min(value = 1, message = "Budget must be greater than 0")
    private double budget;
}
