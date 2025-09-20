package com.springboot.sprigboot_restapi;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.boot.autoconfigure.domain.EntityScan;

@SpringBootApplication
@EntityScan(basePackages = "com.springboot.entities")
public class SprigbootexampleApplication {
	public static void main(String[] args) {
		SpringApplication.run(SprigbootexampleApplication.class, args);
	}
}