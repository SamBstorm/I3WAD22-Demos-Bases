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
            Console.WriteLine("En quel année êtes-vous né ?");
            string anneeNaissance = Console.ReadLine();
            int annee;
            bool isConverted = int.TryParse(anneeNaissance, out annee);
            Console.Clear();
            //Console.Write("J'ai ");
            //Console.Write(34);
            //Console.Write(" ans!");
            //Console.Write("Bonjour {0}, vous avez {1} ans!", name, age);
            Console.Write($"Bonjour {name}, vous avez {2022- annee} ans!");
        }
    }
}
