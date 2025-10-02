package com.conceptswise.conceptwise.repository;

import com.conceptswise.conceptwise.entities.User;
import org.springframework.stereotype.Repository;

import java.util.ArrayList;
import java.util.List;

@Repository
public class UserRepo {
    final List<User> users = new ArrayList<>();
    public void addUserRepo(User user) {
        System.out.println("repo add");
        users.add(user);
        System.out.println("Added the User:" + users.hashCode());
    }

    public List<User> getUsersRepo() {
        System.out.println("repo get ");
        return users;
    }
}
