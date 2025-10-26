package com.bankManagementSystem.controller;

import com.bankManagementSystem.exceptions.ResourceNotFound;
import com.bankManagementSystem.model.Account;
import com.bankManagementSystem.repository.AccountRepository;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;
@RestController
@RequestMapping("/api/accounts")
public class AccountController {

    private final AccountRepository accountRepository;

    public AccountController(AccountRepository accountRepository) {
        this.accountRepository = accountRepository;
    }
//get all accounts
    @GetMapping
    public List<Account> getAllAccounts() {
        return accountRepository.findAll();
    }
    //rest api with  create account
    @PostMapping
    public Account createAccount(@RequestBody Account account){
        return accountRepository.save(account);
    }
    //rest api find account by accountnumber
    @GetMapping("/{id}")
    public ResponseEntity<Account> getAccountDetaisById(@PathVariable int id){
        Account account=accountRepository.findById(id).
                orElseThrow(()->new ResourceNotFound("acoount With "+ id+ " Not Found"));
        return  ResponseEntity.ok(account);
    }
    //update account
    @PutMapping("/{id}")
    public ResponseEntity<Account> updateAccountDetailsById(
            @PathVariable int id,
            @RequestBody Account accountDetails) {

        Account updateAccount = accountRepository.findById(id)
                .orElseThrow(() -> new ResourceNotFound("Account with ID " + id + " not found"));

        updateAccount.setAccount_holder_name(accountDetails.getAccount_holder_name());
        updateAccount.setBalance(accountDetails.getBalance());

        accountRepository.save(updateAccount);
        return ResponseEntity.ok(updateAccount);
    }
    //delete restapi
    @DeleteMapping("/{id}")
    public ResponseEntity<HttpStatus> deleteAccountById(@PathVariable int id){
        Account account=accountRepository.findById(id).
                orElseThrow(()->new ResourceNotFound("Account not found"));
        accountRepository.delete(account);
        return ResponseEntity.noContent().build();
    }
}
