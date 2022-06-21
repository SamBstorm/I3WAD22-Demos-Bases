using System;

namespace Demo_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World!";
            Console.WriteLine(message.Substring(0,5));
            Console.WriteLine(message.Substring(message.Length-6,6));
            //Console.WriteLine(message.Substring(message.Length-6,7));     //Dépassement des valeurs du texte : Crash ArgumentOutOfRangeException
        }
    }
}
