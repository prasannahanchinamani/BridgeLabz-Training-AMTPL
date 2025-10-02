package com.conceptswise.conceptwise.entities;

import jakarta.annotation.PostConstruct;
import jakarta.annotation.PreDestroy;
import lombok.Getter;
import lombok.Setter;
import org.springframework.stereotype.Component;

//@Component
@Getter
@Setter
public class User {
    private String userName;
    private Long contactNumber;

    public User() {
        System.out.println("User no-arg constructor called");
    }

    public User(String userName, Long contactNumber) {
        System.out.println("User constructor with args called");
        this.userName = userName;
        this.contactNumber = contactNumber;
    }

    @PostConstruct
    public void init() {
        System.out.println("User @PostConstruct: Bean initialized");
    }

    @PreDestroy
    public void destroy() {
        System.out.println("User @PreDestroy: Bean destroyed");
    }

    public void showUser() {
        System.out.println("User: " + userName + ", Contact: " + contactNumber);
    }
}
