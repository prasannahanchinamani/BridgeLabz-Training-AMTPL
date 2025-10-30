package net.springcores.employeeManagement.entities;

import jakarta.persistence.*;
import lombok.*;
import org.springframework.stereotype.Component;

import java.util.HashSet;
import java.util.Set;

@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
@Entity
@Component
@Table(name = "employee")
public class Employee {
    //    id, name, email, department
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;
    @Column(name = "employe_name")
    @NonNull
    private String name;
    @Column(name = "email", unique = true, nullable = false)
    private String email;
    @Column(name = "department_Name")
    private String department;
    @ManyToMany
    @JoinTable(
            name = "Employee_project",
            joinColumns = @JoinColumn(name = "employee_id"),
            inverseJoinColumns = @JoinColumn(name = "project_id")
    )
    private Set<Project> projects = new HashSet<>();

    @Override
    public String toString() {
        return "Employee{" +
                "id=" + id +
                ", name='" + name + '\'' +
                ", email='" + email + '\'' +
                ", department='" + department + '\'' +
                '}';
    }
}
