package net.springcores.basic.configuration.entities;

import jakarta.annotation.PostConstruct;
import jakarta.annotation.PreDestroy;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Qualifier;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.stereotype.Component;

@Component
public class Car {
    @Autowired
    @Qualifier("DISEL")
    private Engine engine;
    private String model;

    // Constructor for injection
    public Car(Engine engine) {
        this.engine = engine;
    }
    //setter injection
    @Value("Polo Gt")
    public void setModel(String model){
        this.model=model;
    }
    // init method
    @PostConstruct
    public void init() {
        System.out.println(" Car bean is initialized!");
    }

    // destroy method
    @PreDestroy
    public void destroy() {
        System.out.println(" Car bean is being destroyed!");
    }

    @Override
    public String toString() {
        return "Car{" +
                "engine=" + engine +
                ", model='" + model + '\'' +
                '}';
    }

    public void start() {
        System.out.println("Car is ready to start.......");
        engine.startEngine();
    }

    public void running() {
        System.out.println("car is Moving with 70km");
    }
}

