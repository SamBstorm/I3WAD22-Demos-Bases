using System;

namespace Demo_Condition_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int stock_soda = 10, stock_orangeade = 3, stock_eau = 0;

            Console.WriteLine("Bienvenu dans distributeur-3000: \nVeuillez choisir votre boisson\n(1) Soda\n(2) Orangeade\n(3) Eau");
            if (int.TryParse(Console.ReadLine(), out int choix))
            {
                switch (choix)
                {
                    case 1:
                        if(stock_soda > 0)
                        {
                            Console.WriteLine("Voici votre soda!");
                            stock_soda--;
                        }
                        else
                        {
                            Console.WriteLine("Désolé, plus de soda en stock...");
                        }
                        break;
                    case 2:
                        if (stock_orangeade > 0)
                        {
                            Console.WriteLine("Voici votre orangeade!");
                            stock_orangeade--;
                        }
                        else
                        {
                            Console.WriteLine("Désolé, plus d'orangeade en stock...");
                        }
                        break;
                    case 3:
                        if (stock_eau > 0)
                        {
                            Console.WriteLine("Voici votre eau!");
                            stock_eau--;
                        }
                        else
                        {
                            Console.WriteLine("Désolé, plus d'eau en stock...");
                        }
                        break;
                    default:
                        Console.WriteLine($"Le choix {choix} est incorrect..");
                        break;
                }
            }
            else Console.WriteLine("Choix invalide...");

            Console.WriteLine("Merci d'avoir utiliser distributeur-3000!");

        }
    }
}
