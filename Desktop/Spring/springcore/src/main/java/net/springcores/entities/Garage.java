package net.springcores.entities;

import java.util.List;

public class Garage {
    private List<Car> cars;
    public Garage(List<Car>cars){
        this.cars=cars;
    }
    public void showCars() {
        System.out.println(" Cars in the garage:");
        for (Car c : cars) {
            System.out.println(" - " + c);
        }
    }
}
