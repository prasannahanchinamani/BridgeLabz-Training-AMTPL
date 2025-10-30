package net.springcores.employeeManagement.exceptions;

import org.springframework.http.HttpStatus;

public class ResourceNotFoundException extends RuntimeException {
    public ResourceNotFoundException(String message) {
        super(message);
    }
}

