using System;
using System.Collections.Generic;
using Problema1Proiect.Models;

namespace Problema1Proiect
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Dog(),
                new Cat(),
                new Cow()
            };

            Console.WriteLine("Alege un animal:");
            for (int i = 0; i < animals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {animals[i].Type}");
            }

            Console.Write("Introdu numărul corespunzător: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= animals.Count)
            {
                Animal selectedAnimal = animals[choice - 1];
                Console.WriteLine($"{selectedAnimal.Type} makes sound: {selectedAnimal.MakeSound()}");
            }
            else
            {
                Console.WriteLine("Opțiune invalidă.");
            }

            Console.WriteLine("\nApasă Enter pentru a închide...");
            Console.ReadLine();
        }
    }
}
