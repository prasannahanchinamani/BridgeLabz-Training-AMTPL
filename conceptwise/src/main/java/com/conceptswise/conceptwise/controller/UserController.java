package com.conceptswise.conceptwise.controller;

import com.conceptswise.conceptwise.service.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class UserController {

    private UserService userService;

    // Setter Injection
    @Autowired
    public void setUserService(UserService userService) {
        System.out.println("Setter Injection in Controller(Setter Injection)");
        this.userService = userService;

        // Call service methods
        userService.callFieldInjectionService();   // Calls field injection in repo// Calls setter method in repo
    }
}
