package com.springboot.bean;

//student java object to json through http methods
public class Student {
    private int id;
    private String name;
    private double percentage;

    public Student(int id, String name, double percentage) {
        this.id = id;
        this.name = name;
        this.percentage = percentage;
    }

    public int getId() {
        return id;
    }

    public String getName() {
        return name;
    }

    public double getPercentage() {
        return percentage;
    }

    @Override
    public String toString() {
        return "Student{" +
                "id=" + id +
                ", name='" + name + '\'' +
                ", percentage=" + percentage +
                '}';
    }
}
