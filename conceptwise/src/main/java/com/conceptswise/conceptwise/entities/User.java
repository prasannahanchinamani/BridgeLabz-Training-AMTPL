package com.conceptswise.conceptwise.entities;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

@NoArgsConstructor
@Getter
@Setter
public class User {
    String user_name;
    Long Contact_number;

    public User(String user_name, Long contact_number) {
        this.user_name = user_name;
        Contact_number = contact_number;
    }

    public void user_method() {
        System.out.println("From user method: " + this.hashCode());
    }
}
