package com.conceptswise.conceptwise;

import com.conceptswise.conceptwise.entities.User;
import com.conceptswise.conceptwise.repository.UserRepo;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.ApplicationContext;
import org.springframework.context.ConfigurableApplicationContext;

@SpringBootApplication
public class ConceptwiseApplication {
    public static void main(String[] args) {
        ConfigurableApplicationContext context = SpringApplication.run(ConceptwiseApplication.class, args);
        System.out.println("Started the ConceptWise.........");
        System.out.println("ApplicationContext hashcode: " + context.hashCode());
//        context.close();
        UserRepo userRepo = context.getBean(UserRepo.class);
        userRepo.fieldInjectionRepo();
        context.close();
    }
}
