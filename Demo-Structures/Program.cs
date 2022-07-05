using System;

namespace Demo_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Bienvenu sur la borne automatique de l'{EuroMillion.NOM_JEU}!");

            EuroMillion combinaison_euro;
            Console.WriteLine("Veuillez encoder vos chiffres :");
            Console.Write("Premier chiffre : ");
            combinaison_euro.code1 = int.Parse(Console.ReadLine());
            Console.Write("Second chiffre : ");
            combinaison_euro.code2 = int.Parse(Console.ReadLine());
            Console.Write("Troisième chiffre : ");
            combinaison_euro.code3 = int.Parse(Console.ReadLine());
            Console.Write("Quatrième chiffre : ");
            combinaison_euro.code4 = int.Parse(Console.ReadLine());
            Console.Write("Cinquième chiffre : ");
            combinaison_euro.code5 = int.Parse(Console.ReadLine());


            Console.WriteLine("Veuillez encoder vos étoiles :");
            Console.Write("Première étoile : ");
            combinaison_euro.star1 = short.Parse(Console.ReadLine());
            Console.Write("Seconde étoile : ");
            combinaison_euro.star2 = short.Parse(Console.ReadLine());

            Console.WriteLine($"Votre combinaison est : {combinaison_euro.code1} - {combinaison_euro.code2} - {combinaison_euro.code3} - {combinaison_euro.code4} - {combinaison_euro.code5} *{combinaison_euro.star1} *{combinaison_euro.star2}");

            EuroMillion combinaison_gagnante = new EuroMillion();

            Console.WriteLine($"La combinaison gagnante est : {combinaison_gagnante.code1} - {combinaison_gagnante.code2} - {combinaison_gagnante.code3} - {combinaison_gagnante.code4} - {combinaison_gagnante.code5} *{combinaison_gagnante.star1} *{combinaison_gagnante.star2}");

        }
    }
}

