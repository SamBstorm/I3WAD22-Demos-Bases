using System;

namespace Demo_SecondApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Veuillez indiquer votre nom :");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Et quel est votre âge ?");
            string age = Console.ReadLine();
            Console.Clear();
            //Console.Write("J'ai ");
            //Console.Write(34);
            //Console.Write(" ans!");
            Console.Write("Bonjour {0}, vous avez {1} ans!", name, age);
        }
    }
}
