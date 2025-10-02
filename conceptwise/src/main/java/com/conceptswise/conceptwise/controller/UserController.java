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

    private final UserService userService;

    public UserController(UserService userService) {
        this.userService = userService;
    }

    @PostMapping("/addUser")
    public String addUser(@RequestParam String name, @RequestParam Long contact) {
        User user = new User(name, contact);
        userService.addUserSerive(user);

        // Return hashcode as confirmation
        return "User added with hashcode: " + user.hashCode();
    }

    @GetMapping("/users")
    public List<User> getAllUsers() {
        return userService.getUserService();
    }
}
