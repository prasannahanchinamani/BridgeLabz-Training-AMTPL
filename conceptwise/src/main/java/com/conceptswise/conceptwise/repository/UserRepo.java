package com.conceptswise.conceptwise.repository;

import com.conceptswise.conceptwise.entities.User;
import org.springframework.stereotype.Repository;

@Repository
public class UserRepo {
//    @Autowired
//    final User user;

    public UserRepo() {
        System.out.println("Repo constructor is started");
//        this.user = user;
//    }}
    }

    public void getRepo(User user) {
        System.out.println("from repo with postmapping");
    }
}
