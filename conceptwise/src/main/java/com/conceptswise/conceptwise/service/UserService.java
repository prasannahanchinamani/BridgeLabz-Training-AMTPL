package com.conceptswise.conceptwise.service;

import com.conceptswise.conceptwise.entities.User;
import com.conceptswise.conceptwise.repository.UserRepo;
import org.springframework.stereotype.Service;

@Service
public class UserService {
    final UserRepo userrepo;

    public UserService(UserRepo userrepo) {
        System.out.println("Service constructor is started");
        this.userrepo = userrepo;
    }

    public void callRepo(String name, Long contact) {
        User user = new User(name, contact);
        System.out.println("From Service post mapping , user hashcode: " + user.hashCode());
        userrepo.getRepo(user);
        user.user_method();
    }
}
