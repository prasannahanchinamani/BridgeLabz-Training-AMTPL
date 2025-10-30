package net.springcores.employeeManagement.exceptions;

import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.ResponseStatus;

@ResponseStatus(HttpStatus.NOT_FOUND)
public class DataIntegrityViolationException extends RuntimeException {
    public DataIntegrityViolationException(String msg) {
        super(msg);
    }
}
