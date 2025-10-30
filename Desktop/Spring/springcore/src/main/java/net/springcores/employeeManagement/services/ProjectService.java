package net.springcores.employeeManagement.services;

import net.springcores.employeeManagement.dto.ProjectDTO;
import java.util.List;

public interface ProjectService {
    ProjectDTO createProject(ProjectDTO projectDTO);
    ProjectDTO getProjectById(int id);
    List<ProjectDTO> getAllProjects();
    ProjectDTO updateProject(int id, ProjectDTO projectDTO);
    void deleteProject(int id);
}
