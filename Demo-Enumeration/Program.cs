using System;

namespace Demo_Enumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLigth feu1 = new TrafficLigth();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(feu1.currentColor);
                switch (feu1.currentColor)
                {
                    case TrafficLigthColor.Red:
                        Console.WriteLine("Reste à l'arrêt");
                        break;
                    case TrafficLigthColor.Green:
                        Console.WriteLine("Avance");
                        break;
                    case TrafficLigthColor.Orange:
                        Console.WriteLine("Freine");
                        break;
                }
                feu1.ChangeColor();
            }

            //string[] trafficLigthColorNames = Enum.GetNames(typeof(TrafficLigthColor));
            string[] trafficLigthColorNames = Enum.GetNames<TrafficLigthColor>();
            TrafficLigthColor[] enumColors = Enum.GetValues<TrafficLigthColor>();
            int nbColor = trafficLigthColorNames.Length;
            Console.WriteLine($"Un feu peut avoir {nbColor} couleurs :");
            foreach (string colorName in trafficLigthColorNames)
            {
                Console.WriteLine(colorName);
            }
            #region Parse
            /*Console.WriteLine("Le feu est de quel couleur?");
            string input = Console.ReadLine();
            //TrafficLigthColor colorUser = (TrafficLigthColor)Enum.Parse(typeof(TrafficLigthColor), input);
            TrafficLigthColor colorUser = Enum.Parse<TrafficLigthColor>(input);
            
            */
            #endregion
            #region TryParse
            Console.WriteLine("De quel couleur est le feu?");
            TrafficLigthColor colorUser;
            string input = Console.ReadLine();
            while (!Enum.TryParse<TrafficLigthColor>(input, out colorUser))
            {
                Console.WriteLine("De quel couleur est le feu?");
                input = Console.ReadLine();
            }
            #endregion
            if (feu1.currentColor == colorUser) Console.WriteLine("Pas d'accident, le feu est correct!");
            else Console.WriteLine("Attention, danger sur la route..."); 
        }
    }
}
