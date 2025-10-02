package com.conceptswise.conceptwise.controller;

import com.conceptswise.conceptwise.entities.User;
import com.conceptswise.conceptwise.service.UserService;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
public class UserController {
    final UserService service;

    public UserController(UserService service) {
        System.out.println("controller constructor");
        this.service = service;
    }

    @PostMapping("/addUser")
    public String callService(@RequestParam String name, @RequestParam Long contact) {
        service.callRepo(name, contact);
        return "User processed";
    }

    @GetMapping("/getUser")
    public String getuser() {
        return service.toString();
    }
}
