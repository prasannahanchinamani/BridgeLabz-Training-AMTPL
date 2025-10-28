package net.springcores.entities;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.stereotype.Component;

@Component("DISEL")
//@Qualifier("DISEL")
public class Engine {
    private String type="disel";

    public Engine() {

    }
//   @Autowired
    public Engine(String type) {
        this.type = type;
    }

    public void startEngine() {
        System.out.println("Engine type: " + type + " started successfully!");
    }

    @Override
    public String toString() {
        return type + " Engine";
    }
}
