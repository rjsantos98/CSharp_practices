using System;
using System.Globalization;

namespace URI1049Animal
{
    class Program
    {
        static void Main(string[] args)
        {

            string a, b, c, animal;

            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();

            if ((a == "vertebrado") && (b == "ave") && (c == "carnivoro"))
            {
                animal = "aguia";
            }
            else if ((a == "vertebrado") && (b == "ave") && (c == "onivoro"))
            {
                animal = "pomba";
            }
            else if ((a == "vertebrado") && (b == "mamifero") && (c == "onivoro"))
            {
                animal = "homem";
            }
            else if ((a == "vertebrado") && (b == "mamifero") && (c == "herbivoro"))
            {
                animal = "vaca";

            }
            else if ((a == "invertebrado") && (b == "inseto") && (c == "hematofago"))
            {
                animal = "pulga";
            }
            else if ((a == "invertebrado") && (b == "inseto") && (c == "herbivoro"))
            {
                animal = "lagarta";
            }
            else if ((a == "invertebrado") && (b == "anelideo") && (c == "hematofago"))
            {
                animal = "sanguessuga";
            }
            else
            {
                animal = "minhoca";
            }

            Console.WriteLine(animal);


        }
    }
}

