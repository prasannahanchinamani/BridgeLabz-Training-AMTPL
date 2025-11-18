
using AdvanceConcept.Oops;
//using AdvanceConcepts.basics;
using AdvanceConcepts.Basics;
using AdvanceConcepts.Oops;
using Project.Team1;
using Project.Team2;

//namespace AdvanceConcepts.TypeConversion;

public class Progrm
{
    static void Main(string[] args)
    {
        //this one without any name space
        ParamExample paramExample = new ParamExample();

        //    paramExample.DisplayNumbers(1, 2, 3);
        //    paramExample.DisplayNumbers(10, 20, 30, 40, 50);
        //    paramExample.DisplayNumbers();
        //ImplicitTypeCasting implicitTypeCasting = new ImplicitTypeCasting();
        //implicitTypeCasting. DemonstrateImplicitCasting();
        //ExplicitTypeCasting explicitTypeCasting = new ExplicitTypeCasting();
        //explicitTypeCasting.DemonstrateExplicitCasting();
        //ReadWriteFromConsole readWriteFromConsole = new ReadWriteFromConsole();
        //readWriteFromConsole.ReadAndWrite();
        MethodTypeDemo.run();
        Team1 t1 = new Team1();
        t1.DisplayTeam();

        Team2 t2 = new Team2();
        t2.DisplayTeam();
        Console.WriteLine("Constructor Examples");
        Demo1 demo1 = new Demo1(); // static is called only once
        Demo1 demo2 = new Demo1();
        Demo1 demo3 = new Demo1(1);
        Console.WriteLine("Count = " + Demo1.Count);
        UpcastingDowncastingExample ex = new UpcastingDowncastingExample();
        UpcastingDowncastingExample.UpcastingDownCasting();
        StaticMethodExample st = new StaticMethodExample();
        StaticMethodExample.Greet();
    }
}