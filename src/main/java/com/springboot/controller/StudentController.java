package com.springboot.controller;

import com.springboot.bean.Student;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.util.Arrays;
import java.util.List;

@RestController
public class StudentController {
    @GetMapping("/student")
    public Student getStudent() {
        Student studnet = new Student(
                1, "Prasanna", 88.88
        );
        return studnet;
    }

    @GetMapping("/students")
    public List<Student> getStudents() {
        return Arrays.asList(
                new Student(1, "Prasanna", 88.88),
                new Student(2, "Ravi", 76.50),
                new Student(3, "Sneha", 92.30)
        );
    }

    //http://localhost:8080/student{1}
    // GET: Read student by ID
    @GetMapping("/student/{id}")
//    {id}->uri templete
    //@PathVariable used to bind uri templete
    public String getStudentById(@PathVariable int id) {
        return "Fetching student with ID: " + id + "+\\n Student detais " + getStudents().get(id - 1).toString();
    }

    // GET: Read student by ID and name
    @GetMapping("/student/{id}/{name}")
    // http://localhost:8080/student{1}{prasanna}
//    //@PathVariable used to bind uri templete  id !=studentid explicitly bind
    public String getStudentDetails(@PathVariable("id") int studentid, @PathVariable String name) {
        return "Student ID: " + studentid + ", Name: " + name;
    }
    // http://localhost:8080/student/query?id=1&name=prasanna&percentage=89.0/
  //  http://localhost:8080/student/query?id=1&name=prasanna&percentage=89.0
    @GetMapping("student/query")
    public String getStudnet(@RequestParam int id, @RequestParam String name,  @RequestParam double percentage) {
        return "id " + id + " Name " + name + " percentage " + percentage;
    }

}

