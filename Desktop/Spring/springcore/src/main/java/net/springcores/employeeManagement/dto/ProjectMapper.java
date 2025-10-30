package net.springcores.employeeManagement.dto;

import lombok.Data;
import net.springcores.employeeManagement.dto.ProjectDTO;
import net.springcores.employeeManagement.entities.Project;
@Data
public class ProjectMapper {

    // Convert Entity ➜ DTO
    public static ProjectDTO toDTO(Project project) {
        ProjectDTO dto = new ProjectDTO();
        dto.setId(project.getId());
        dto.setName(project.getName());
        dto.setBudget(project.getBudget());
        return dto;
    }

    // Convert DTO ➜ Entity
    public static Project toEntity(ProjectDTO dto) {
        Project project = new Project();
        project.setId(dto.getId());
        project.setName(dto.getName());
        project.setBudget(dto.getBudget());
        return project;
    }
}
