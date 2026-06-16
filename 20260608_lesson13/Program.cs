using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

class Program
{
    static void Main()
    {
        try
        {
            List<Fruit> fruits = new List<Fruit>
            {
                new Fruit("Apple", "red"),
                new Fruit("Banana", "yellow"),
                new Citrus("Lemon", "yellow", 0.953),
                new Citrus("Orange", "orange", 1.745),
                new Citrus("Grapefruit", "yellow", 2.131)
            };
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Yellow fruits:");
            foreach (Fruit fruit in fruits.Where(f => f.Color.ToLower() == "yellow"))
            {
                fruit.Print();
            }
            Console.ResetColor();

            List<Fruit> sortedFruits = fruits
                .OrderBy(f => f.Name)
                .ToList();

            using (StreamWriter writer = new StreamWriter("sorted_fruits.txt"))
            {
                foreach (Fruit fruit in sortedFruits)
                {
                    fruit.Print(writer);
                }
            }

            XmlSerializer serializer = new XmlSerializer(
                typeof(List<Fruit>),
                new Type[] { typeof(Citrus) }
            );

            using (FileStream fs = new FileStream("fruits.xml", FileMode.Create))
            {
                serializer.Serialize(fs, fruits);
            }

            List<Fruit> deserializedFruits;

            using (FileStream fs = new FileStream("fruits.xml", FileMode.Open))
            {
                deserializedFruits = (List<Fruit>)serializer.Deserialize(fs);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nDeserialized fruits:");
            foreach (Fruit fruit in deserializedFruits)
            {
                fruit.Print();
            }
            Console.ResetColor();
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("\nDone.");
            Console.ResetColor();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}