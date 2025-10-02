package com.conceptswise.conceptwise.service;

import com.conceptswise.conceptwise.entities.User;
import com.conceptswise.conceptwise.repository.UserRepo;
import org.springframework.stereotype.Service;

import java.util.List;
@Service
public class UserService {
    final UserRepo userrepo;

    public UserService(UserRepo userrepo) {
        System.out.println("service constructor ");
        this.userrepo = userrepo;
    }

    public void addUserSerive(User user) {
        System.out.println("service add");
        userrepo.addUserRepo(user);
        user.user_method();
    }

    public List<User> getUserService() {
        System.out.println("service get ");
        return userrepo.getUsersRepo();
    }
}
