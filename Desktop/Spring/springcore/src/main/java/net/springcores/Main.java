package net.springcores;


//import java.applet.AppletContext;

import net.springcores.configuration.Appconfig;
import net.springcores.entities.Car;
import net.springcores.entities.Garage;
import org.springframework.context.ApplicationContext;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class Main {
    public static void main(String[] args) {
        System.out.println("Hello world!");
        ApplicationContext context=new AnnotationConfigApplicationContext(Appconfig.class);
//        Car car= (Car) context.getBean("car");
        Car car= (Car) context.getBean(Car.class);
        car.start();
//        car.running();
        Garage garage= (Garage) context.getBean(Garage.class);
        garage.showCars();
//        context.clone();
        ((AnnotationConfigApplicationContext) context).close();
    }
}