package net.springcores.employeeManagement.entities;

import jakarta.persistence.*;
import jakarta.validation.constraints.Min;
import lombok.*;
import org.springframework.stereotype.Component;

//import javax.naming.Name;
import java.util.HashSet;
import java.util.Set;

@Entity
@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
@Component
@Table(name = "project")
public class Project {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int id;

    @Column(unique = true, nullable = false)
    private String name;
    @NonNull
    @Column(name = "budget")
    @Min(value = 1, message = "must have atleast  1")
    private double budget = 1;

    @ManyToMany(mappedBy = "projects")  //
    private Set<Employee> employees = new HashSet<>();

    @Override
    public String toString() {
        return "Project{" +
                "id=" + id +
                ", name='" + name + '\'' +
                ", budget=" + budget +
                '}';
    }
}
