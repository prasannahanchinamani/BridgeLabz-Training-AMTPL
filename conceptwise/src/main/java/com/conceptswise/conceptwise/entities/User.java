package com.conceptswise.conceptwise.entities;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import org.springframework.context.annotation.Bean;
import org.springframework.stereotype.Component;
import org.springframework.stereotype.Controller;

@NoArgsConstructor
@AllArgsConstructor
@Getter
@Setter
@Component
public class User {
    String user_name;
    Long Contact_number;

    public void user_method() {
        System.out.println("From user method");
    }

}
