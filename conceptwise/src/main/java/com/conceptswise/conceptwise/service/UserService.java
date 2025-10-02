package com.conceptswise.conceptwise.service;

import com.conceptswise.conceptwise.repository.UserRepo;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class UserService {

    private final UserRepo repo; // Constructor injection

    @Autowired
    public UserService(UserRepo repo) {
        System.out.println("Service constructor called (Constructor Injection)");
        this.repo = repo;
    }

    // Call field injection method in UserRepo
    public void callFieldInjectionService() {
        System.out.println("Calling Field Injection in Repo from Service:(Filed injection");
        repo.fieldInjectionRepo();
    }
}
