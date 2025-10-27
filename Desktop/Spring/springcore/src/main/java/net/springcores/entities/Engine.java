package net.springcores.entities;

public class Engine {
    private String type;

    public Engine() {

    }

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
