package com.conceptswise.conceptwise.configure;

import com.conceptswise.conceptwise.entities.User;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class UserConfig {

    @Bean
    public User user() {
        System.out.println("User bean is Intialized");
        return new User("Prasanna", 12345L);
    }

}
