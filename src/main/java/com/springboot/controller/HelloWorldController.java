package com.springboot.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

//@Controller
//@ResponseBody
@RestController //@Controller+@ResponseBody
public class HelloWorldController {
    //HTTP GET REQUEST
    //http://localhost:8080/hello-world;
    @GetMapping("/hello-world")
    public String helloWord(){
        return "1st RestApi";
    }
}
