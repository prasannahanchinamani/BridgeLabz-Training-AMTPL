package com.bankManagementSystem;

import com.bankManagementSystem.model.Account;
import com.bankManagementSystem.repository.AccountRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class BankManagementSystemApplication implements CommandLineRunner {

    public static void main(String[] args) {
        SpringApplication.run(BankManagementSystemApplication.class, args);
    }

    @Autowired
    private AccountRepository accountRepository;
    @Override
    public void run(String... args) throws Exception {
        if(accountRepository.count() == 0) {
            accountRepository.save(new Account("Prajwal", 250000.0));
            accountRepository.save(new Account("Pramodh", 140000.0));
        }
    }

}
