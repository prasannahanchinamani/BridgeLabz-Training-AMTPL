package net.springcores.entities;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

import java.util.List;
@Component
public class Garage {
    @Autowired
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
