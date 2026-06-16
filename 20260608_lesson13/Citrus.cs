using System;
using System.IO;

[Serializable]
public class Citrus : Fruit
{
    public double VitaminC { get; set; }

    public Citrus()
    {

    }

    public Citrus(string name, string color, double vitaminC)
        : base(name, color)
    {
        VitaminC = vitaminC;
    }

    public override void Input()
    {
        base.Input();

        Console.Write("Enter vitamin C content in grams: ");

        double vitaminC;

        while (!double.TryParse(Console.ReadLine(), out vitaminC))
        {
            Console.Write("Wrong input. Enter number: ");
        }

        VitaminC = vitaminC;
    }

    public override void Print()
    {
        Console.WriteLine(ToString());
    }

    public override void Input(StreamReader reader)
    {
        base.Input(reader);
        VitaminC = double.Parse(reader.ReadLine());
    }

    public override void Print(StreamWriter writer)
    {
        writer.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"Citrus: {Name}, Color: {Color}, Vitamin C: {VitaminC} g";
    }
} 