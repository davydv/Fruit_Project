using System;

[Serializable]
public class Fruit
{
    public string Name { get; set; }
    public string Color { get; set; }

    public Fruit() { }

    public Fruit(string name, string color)
    {
        Name = name;
        Color = color;
    }

    public virtual void Input()
    {
        Console.Write("Enter fruit name: ");
        Name = Console.ReadLine();

        Console.Write("Enter fruit color: ");
        Color = Console.ReadLine();
    }

    public virtual void Print()
    {
        Console.WriteLine(ToString());
    }

    public virtual void Input(StreamReader reader)
    {
        Name = reader.ReadLine();
        Color = reader.ReadLine();
    }

    public virtual void Print(StreamWriter writer)
    {
        writer.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"Fruit: {Name}, Color: {Color}";
    }
}