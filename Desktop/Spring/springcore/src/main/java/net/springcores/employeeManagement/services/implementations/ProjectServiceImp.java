package net.springcores.employeeManagement.services.implementations;

import jakarta.transaction.Transactional;
import lombok.RequiredArgsConstructor;
import net.springcores.employeeManagement.dto.ProjectDTO;
import net.springcores.employeeManagement.dto.ProjectMapper;
import net.springcores.employeeManagement.entities.Project;
import net.springcores.employeeManagement.repository.ProjectRepository;
import net.springcores.employeeManagement.services.ProjectService;
import org.springframework.stereotype.Service;

import java.util.List;
import java.util.stream.Collectors;

@Service
@Transactional
@RequiredArgsConstructor
public class ProjectServiceImp implements ProjectService {
    private final ProjectRepository projectRepository;

    @Override
    public ProjectDTO createProject(ProjectDTO projectDTO) {
        Project project = ProjectMapper.toEntity(projectDTO);
        Project createProject = projectRepository.save(project);
        return ProjectMapper.toDTO(createProject);
    }

    @Override
    public ProjectDTO getProjectById(int id) {
        Project findById = projectRepository.findById(id).
                orElseThrow(() -> new RuntimeException(" Project Not find" + id));
        return ProjectMapper.toDTO(findById);
    }

    @Override
    public List<ProjectDTO> getAllProjects() {
        return projectRepository.findAll()
                .stream()
                .map(ProjectMapper::toDTO)
                .collect(Collectors.toList());
    }

    @Override
    public ProjectDTO updateProject(int id, ProjectDTO projectDTO) {
        Project project = projectRepository.findById(id)
                .orElseThrow(() -> new RuntimeException("Project not found with id: " + id));
        project.setName(projectDTO.getName());
        project.setBudget(projectDTO.getBudget());

        Project updated = projectRepository.save(project);
        return ProjectMapper.toDTO(updated);
    }

    @Override
    public void deleteProject(int id) {
        projectRepository.deleteById(id);
    }
}
