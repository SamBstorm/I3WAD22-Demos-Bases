using System;

namespace Demos_Condition_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez présenter votre tiquet...");
            Console.WriteLine("Indiquez le nombre de trajet restant ou appuis sur n'importe quel touche...");
            int nbTravel;
            bool haveTicket = int.TryParse(Console.ReadLine(), out nbTravel);

            if (!haveTicket)
            {
                Console.WriteLine("Vous n'avez pas de tiquet, allez en acheter un...");
            }
            else if (nbTravel == 1 )
            {
                Console.WriteLine("Vous pouvez passer! Attention c'est votre dernier trajet...");
                nbTravel = nbTravel - 1;
                haveTicket = false;
            }
            else if (nbTravel > 0)
            {
                Console.WriteLine("Vous pouvez passer!");
                nbTravel = nbTravel - 1;
            }
            else
            {
                Console.WriteLine("Vous ne pouvez pas passer! Allez acheter un nouveau tiquet!");
            }


            Console.WriteLine("Merci d'utiliser rail-3000!");
        }
    }
}
