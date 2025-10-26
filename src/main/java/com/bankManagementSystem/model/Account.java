package com.bankManagementSystem.model;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

//@Getter
@Setter
//@NoArgsConstructor  // REQUIRED for Hibernate
@AllArgsConstructor
@Entity
@Table(name = "account")
public class Account {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer account_number;
public Account(){}
    private String account_holder_name;
    private Double balance;

    // Optional constructor without ID
    public Account(String account_holder_name, Double balance) {
        this.account_holder_name = account_holder_name;
        this.balance = balance;
    }

    public void setAccount_number(Integer account_number) {
        this.account_number = account_number;
    }

    public void setAccount_holder_name(String account_holder_name) {
        this.account_holder_name = account_holder_name;
    }

    public void setBalance(Double balance) {
        this.balance = balance;
    }

    public Integer getAccount_number() {
        return account_number;
    }

    public String getAccount_holder_name() {
        return account_holder_name;
    }

    public Double getBalance() {
        return balance;
    }

    @Override
    public String toString() {
        return "Account{" +
                "account_number=" + account_number +
                ", account_holder_name='" + account_holder_name + '\'' +
                ", balance=" + balance +
                '}';
    }
}
