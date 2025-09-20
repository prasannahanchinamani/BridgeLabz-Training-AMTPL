package com.springboot.repository;

import com.springboot.entities.Employee;
import org.springframework.data.jpa.repository.JpaRepository;

//jpaRepo ->do Crud operation on Class EMployee use the Long primary id
public interface EmployeeRepo extends JpaRepository<Employee, Long> {
}
