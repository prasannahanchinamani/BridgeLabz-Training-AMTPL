package com.springboot.entities;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import org.springframework.boot.autoconfigure.web.WebProperties;
@Getter   //lombok boilerplate genearate getter
@Setter   //lombok generate setter
@NoArgsConstructor //no agrgument constructor
@AllArgsConstructor //all argument constructor
//@Entity  is that jpi make sure that class is jpa(jakata persistance)
@Entity
@Table(name="employee")//create table
public class Employee {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)//like primary key
    private  Long id;
    @Column(name="first_Name")//no required automatically give colum name as filed name
    private String first_Name;
    private String last_Name;
    @Column(name="email",nullable = false,unique = true)//with constarins
    private String email;
}
