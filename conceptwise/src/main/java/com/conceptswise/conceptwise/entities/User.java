package com.conceptswise.conceptwise.entities;

import jakarta.annotation.PostConstruct;
import jakarta.annotation.PreDestroy;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

@NoArgsConstructor
@Getter
@Setter
//@Component
public class User {
    String user_name;
    Long Contact_number;

//    @Autowired
    public User(String user_name, Long contact_number) {
        System.out.println("user constructor");
        this.user_name = user_name;
        Contact_number = contact_number;
    }

     @PostConstruct
    public void user_method() {
         System.out.println("IntialisationBean : Interface after Bean is Created");
        System.out.println("From user method: " + this.hashCode());
    }
    @PreDestroy
    public void destroy(){
        System.out.println("DisposableBean before bean Destroy:");
        System.out.println("From user Method "+this.hashCode());
    }
}
