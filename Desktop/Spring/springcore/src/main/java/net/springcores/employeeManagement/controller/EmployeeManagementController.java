package net.springcores.employeeManagement.controller;

import lombok.RequiredArgsConstructor;
import net.springcores.employeeManagement.dto.EmployeeDTO;
import net.springcores.employeeManagement.dto.ProjectDTO;
import net.springcores.employeeManagement.services.EmployeeService;
import net.springcores.employeeManagement.services.ProjectService;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import jakarta.validation.Valid;
import java.util.List;

@RestController
@RequiredArgsConstructor
@RequestMapping("/api")
public class EmployeeManagementController {

    private final EmployeeService employeeService;
    private final ProjectService projectService;

    //  Create employee
    @PostMapping("/employee")
    public ResponseEntity<EmployeeDTO> createEmployee(@Valid @RequestBody EmployeeDTO dto) {
        return new ResponseEntity<>(employeeService.createEmployee(dto), HttpStatus.CREATED);
    }

    //  Get all employees
    @GetMapping("/employee")
    public ResponseEntity<List<EmployeeDTO>> getAllEmployees() {
        return ResponseEntity.ok(employeeService.getAllEmployees());
    }

    //  Get one employee by ID
    @GetMapping("/employee/{id}")
    public ResponseEntity<EmployeeDTO> getEmployee(@PathVariable int id) {
        return ResponseEntity.ok(employeeService.getEmployeeById(id));
    }

    // Update employee
    @PutMapping("/employee/{id}")
    public ResponseEntity<EmployeeDTO> updateEmployee(
            @PathVariable int id,
            @Valid @RequestBody EmployeeDTO dto
    ) {
        return ResponseEntity.ok(employeeService.updateEmployee(id, dto));
    }

    //  Delete employee
    @DeleteMapping("/employee/{id}")
    public ResponseEntity<Void> deleteEmployee(@PathVariable int id) {
        employeeService.deleteEmployee(id);
        return ResponseEntity.noContent().build();
    }

    //  Create project
    @PostMapping("/project")
    public ResponseEntity<ProjectDTO> createProject(@Valid @RequestBody ProjectDTO dto) {
        return new ResponseEntity<>(projectService.createProject(dto), HttpStatus.CREATED);
    }

    //  Get all projects
    @GetMapping("/project")
    public ResponseEntity<List<ProjectDTO>> getAllProjects() {
        return ResponseEntity.ok(projectService.getAllProjects());
    }

    //  Update project
    @PutMapping("/project/{id}")
    public ResponseEntity<ProjectDTO> updateProject(@PathVariable int id, @RequestBody ProjectDTO dto) {
        return ResponseEntity.ok(projectService.updateProject(id, dto));
    }

    // Delete project
    @DeleteMapping("/project/{id}")
    public ResponseEntity<Void> deleteProject(@PathVariable int id) {
        projectService.deleteProject(id);
        return ResponseEntity.noContent().build();
    }
}
