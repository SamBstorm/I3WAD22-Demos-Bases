using System;

namespace Demo_Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogging parcours1;
            parcours1.Courir(4);
        }
    }

    public struct Jogging
    {
        public void Courir(int distance)
        {
            distance = distance - 1;
            Console.WriteLine($"Il me reste {distance} m à courir.");
            if (distance == 0) return;
            this.Courir(distance);
            Console.WriteLine($"Je rentre chez moi, j'ai marché {distance} m.");
        }
    }
}
