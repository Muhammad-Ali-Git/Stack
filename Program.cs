using System;
using System.Net.Quic;
using System.Runtime.CompilerServices;

class Ali
{
    public static void Main()
    {
        Console.WriteLine("This program prints details of a Costumer using Stack (Pops Latest Entry at Start).");
        Console.WriteLine("--------------------------------------------------------------------------------------");

        Costumer C1 = new Costumer();
        C1.ID = 101;
        C1.Name = "John Lorusso";
        C1.Salary = 5000;
        C1.Gender = "Male";

        Costumer C2 = new Costumer();
        C2.ID = 102;
        C2.Name = "Ibrahim Arabaki";
        C2.Salary = 6000;
        C2.Gender = "Male";

        Costumer C3 = new Costumer();
        C3.ID = 103;
        C3.Name = "Mary Luisse";
        C3.Salary = 7000;
        C3.Gender = "Female";

        Stack <Costumer> SC1 = new Stack<Costumer>();
        SC1.Push(C1);
        SC1.Push(C2);
        SC1.Push(C3);

        Console.WriteLine("Using Pop Method (Total Count Decreases)");

        Console.WriteLine("---------------------------------------------------------------------------------------");
        Costumer QC1 = SC1.Pop();
        Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Gender = {3}", QC1.ID, QC1.Name, QC1.Salary, QC1.Gender);
        Console.WriteLine("Total Items in Queue = {0}", SC1.Count);

        Console.WriteLine("---------------------------------------------------------------------------------------");
        Costumer QC2 = SC1.Pop();
        Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Gender = {3}", QC2.ID, QC2.Name, QC2.Salary, QC2.Gender);
        Console.WriteLine("Total Items in Queue = {0}", SC1.Count);

        Console.WriteLine("---------------------------------------------------------------------------------------");
        Costumer QC3 = SC1.Pop();
        Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Gender = {3}", QC3.ID, QC3.Name, QC3.Salary, QC3.Gender);
        Console.WriteLine("Total Items in Queue = {0}", SC1.Count);

        Stack <Costumer> SC2 = new Stack<Costumer>();
        SC2.Push(C1);
        SC2.Push(C2);
        SC2.Push(C3);
        
        Console.WriteLine("---------------------------------------------------------------------------------------");
        Console.WriteLine("Using Foreach Loop (Total Count Remains Same & Prints All Items in The Stack)");

        foreach (Costumer C in SC2)
        {
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Gender = {3}", C.ID, C.Name, C.Salary, C.Gender);
            Console.WriteLine("Total Items in Queue = {0}", SC2.Count);
        }

        Console.WriteLine("---------------------------------------------------------------------------------------");
        Console.WriteLine("Using Peek Method (Total Count Remains Same but Only Prints the Item at the Start of Stack)");

        Console.WriteLine("---------------------------------------------------------------------------------------");
        Costumer QC4 = SC2.Peek();
        Console.WriteLine("Peek 1");
        Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Gender = {3}", QC4.ID, QC4.Name, QC4.Salary, QC4.Gender);
        Console.WriteLine("Total Items in Queue = {0}", SC2.Count);

        Console.WriteLine("---------------------------------------------------------------------------------------");
        Costumer QC5 = SC2.Peek();
        Console.WriteLine("Peek 2");
        Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Gender = {3}", QC5.ID, QC5.Name, QC5.Salary, QC5.Gender);
        Console.WriteLine("Total Items in Queue = {0}", SC2.Count);
    }
}

public class Costumer
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public string Gender { get; set; }
}