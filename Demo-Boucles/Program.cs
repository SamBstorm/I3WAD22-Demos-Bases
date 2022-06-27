using System;

namespace Demo_Boucles
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Boucle for(...;...;...)
            #region Arithmétique
            //for (int i = 0; i < 10; i+=2)
            //{
            //    Console.ForegroundColor = (ConsoleColor)i;
            //    Console.WriteLine(i);
            //}
            ////Console.WriteLine(i); //i est déclaré dans les parenthèse du for, donc pas accessible depuis l'extérieur
            #endregion
            #region non arithmétique

            //Console.WriteLine("Veuillez indiquer un numéro :");
            //bool isOk = true;
            //for (string input = Console.ReadLine(); !int.TryParse(input, out _) && isOk; input = Console.ReadLine())
            //{
            //    Console.WriteLine("Un numéro, tu sais ce que c'est?");
            //    isOk = Console.ReadLine() == "Oui";
            //}
            //Console.WriteLine("Ok, c'est bon pour aujourd'hui, tu m'épuises...");
            #endregion
            #endregion

            #region while(...)
            #region Arthimétique

            //int x = 0;

            //while (x < 10)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}

            //Console.WriteLine(x);

            #endregion
            #region non-arithmétique

            //Console.WriteLine("Veuillez entrer un nombre :");
            //string input = Console.ReadLine();
            //int i;

            //while(!int.TryParse(input, out i) || i > 100)
            //{
            //    Console.WriteLine("Veuillez entrer un nombre correct :");
            //    input = Console.ReadLine();
            //}

            //Console.WriteLine($"Le nombre {i} est un nombre...");
            #endregion
            #endregion

            #region do{ ... } while(...);

            string input;
            int i;
            string message = "Veuillez entrer un nombre";
            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
                message = "Veuillez entrer un nombre correct...";
            } while (!int.TryParse(input, out i));

            Console.WriteLine($"Le nombre {i} est un nombre...");

            #endregion
        }
    }
}
