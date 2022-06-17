using System;

namespace Demo_Coalesce
{
    class Program
    {
        static void Main(string[] args)
        {
            string theBestProf = null;
            theBestProf = theBestProf ?? "Aude";
        }
    }
}
