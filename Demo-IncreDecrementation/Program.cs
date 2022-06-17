using System;

namespace Demo_IncreDecrementation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;

            Console.WriteLine($"Que font :{(--i*i++)}");    //priporité au --i, donc i valant 5, devient 4 : 4*4 est exécuté, ensuite seulement après affichage, le i++ est exécuté car non prioritaire, i redevient 5
            Console.WriteLine(i);
        }
    }
}
