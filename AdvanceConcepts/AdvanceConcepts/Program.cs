
using AdvanceConcept.Oops;
using AdvanceConcepts.Oops;
class Progrm
{
    static void Main(string[] args)
    {
        //Create an object of the Dog class
        Dog d1 = new Dog();
        d1.Name = "Tommy";
        d1.Age = 3;
        d1.Bark();

        //getter and setter example
        Console.WriteLine("Encapsulation Example:");
        AgeValidation AgeValidation = new AgeValidation();
        AgeValidation.Age = 25; //setter
        Console.WriteLine("Age: " + AgeValidation.Age); //getter

        Console.WriteLine("Inheritance Example:");
        AdvanceConcept.Oops.Animal1 animal = new AdvanceConcept.Oops.Animal1();
        animal.Eat();
        Cat cat = new Cat();
        cat.Eat(); // Inherited method
        cat.Meow();
        Console.WriteLine("Polymorphism Example:");
        //compile -time polymorphism 
        Addition addition = new Addition();
        int addedTwoNumbers = addition.Add(5, 10);
        Console.WriteLine("Addition of two numbers: " + addedTwoNumbers);
        int addedThreeNumbers = addition.Add(5, 10, 15);
        Console.WriteLine("Addition of three numbers: " + addedThreeNumbers);
        AddAndMultiplyWith5 addAndMultiplyWith5 = new AddAndMultiplyWith5();
        //run-time polymorphism
        int res = addAndMultiplyWith5.Add(5, 10); // overridden method
        Console.WriteLine("Addition and Multiplication with 5: " + res);

        Console.WriteLine("Abstraction Example:");
        Animalabstract animal1 = new Dog1();
        animal1.MakeSound();
        Console.WriteLine("Interface Example:");

        IVehicle v = new Car();
        v.Start();
        v.Stop();

        //Tostring override example
        ToStringOverride toStringOverride = new ToStringOverride();
       toStringOverride.Id = 1;
        toStringOverride.Name = "Prasanna";
        Console.WriteLine("ToString Override Example:");
        Console.WriteLine(toStringOverride.ToString());

    }
}