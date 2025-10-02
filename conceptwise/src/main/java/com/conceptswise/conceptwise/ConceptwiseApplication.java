package com.conceptswise.conceptwise;

import com.conceptswise.conceptwise.entities.User;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.ApplicationContext;

@SpringBootApplication
public class ConceptwiseApplication {
    public static void main(String[] args) {
        ApplicationContext context = SpringApplication.run(ConceptwiseApplication.class, args);
        System.out.println("Started the ConceptWise.........");
        System.out.println("ApplicationContext hashcode: " + context.hashCode());
//        User user = context.getBean(User.class);
//        user.user_method();
//        System.out.println("user Object " + user.hashCode());

    }
}
