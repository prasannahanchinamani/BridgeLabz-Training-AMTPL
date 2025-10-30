package net.springcores.basic.configuration;//package net.springcores;

import net.springcores.basic.configuration.Appconfig;
import net.springcores.basic.configuration.entities.Car;
import net.springcores.basic.configuration.entities.Garage;
import org.springframework.context.ApplicationContext;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;
import org.springframework.context.support.ClassPathXmlApplicationContext;

public class Main {
    public static void main(String[] args) {
        System.out.println("Hello world!");

        // use try-with-resources to auto-close context
//        try (AnnotationConfigApplicationContext context =
//                     new AnnotationConfigApplicationContext(Appconfig.class)) {
        try (ClassPathXmlApplicationContext context =
                     new ClassPathXmlApplicationContext("bean.xml")) {

            Car car = context.getBean("car1",Car.class);
            car.start();
            Garage garage = context.getBean(Garage.class);
            garage.showCars();
        }
        System.out.println("Application closed!");
    }
}
