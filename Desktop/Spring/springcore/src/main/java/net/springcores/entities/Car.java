package net.springcores.entities;

public class Car {
    private Engine engine;
    private String model;

    // Constructor for injection
    public Car(Engine engine) {
        this.engine = engine;
    }
    //setter injection
    public void setModel(String model){
        this.model=model;
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

