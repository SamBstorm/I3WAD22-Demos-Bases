using System;

namespace Demo_Ternaire
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 5;
            string result = (i == 5) ? "OK" : "NOT OK";
            Console.WriteLine((DateTime.Now.Second < 10) ? $"0{DateTime.Now.Second}" : DateTime.Now.Second);

            if (i == 5)
            {
                result = "OK";
            }
            else
            {
                result = "NOT OK";
            }

            if (i == 5)
            {
                result = "OK";
                Console.WriteLine(result);
            }
            else
            {
                result = "NOT OK";
                throw new Exception();
            }
        }
    }
}
