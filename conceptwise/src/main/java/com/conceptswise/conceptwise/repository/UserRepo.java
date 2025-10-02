package com.conceptswise.conceptwise.repository;

import com.conceptswise.conceptwise.entities.User;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

@Repository
public class UserRepo {
    @Autowired
    User user;

    public void fieldInjectionRepo() {
        System.out.println("Filed Injection...");
        user.showUser();
    }
}
