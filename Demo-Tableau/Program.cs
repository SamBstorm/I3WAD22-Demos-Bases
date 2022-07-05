using System;
using System.Collections;
using System.Collections.Generic;

namespace Demo_Tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] jourSemaine = { "Lu", "Ma", "Me", "Je", "Ve", "Sa", "Di" };
            // Les indices du tableau :   0      1      2     3      4      5      6

            //Aujourd'hui nous somme Lundi, pour obtenir la bon jour, il me faut utiliser l'index 0 (Première du tableau)
            Console.WriteLine($"Aujourd'hui nous somme {jourSemaine[0]}");

            string[,] jourSemaineMultilangue =
                {
                    { "Lu", "Ma", "Me", "Je", "Ve", "Sa", "Di" },
// Les indices du 0:      0      1      2     3      4      5      6
                    { "Ma", "Di", "Wo", "Do", "Vr", "Za", "Zo" },
// Les indices du 1:      0      1      2     3      4      5      6
                    { "Mo", "Tu", "We", "Th", "Fr", "Sa", "Su"}
// Les indices du 2:      0      1      2     3      4      5      6
                };

            //Je veux dire en anglais que demain nous sommes Tuesday, il me faut repérer l'indice de la langue (premier axe), suivi, de l'indice du jour (seconde axe) :

            Console.WriteLine($"Tomorrow, we are {jourSemaineMultilangue[2,1]}!");

            string[,,] jourSemaineMultiFormat =
                {
                    {
                        { "Lu", "Ma", "Me", "Je", "Ve", "Sa", "Di" },
    // Les indices du 0:      0      1      2     3      4      5      6
                        { "Ma", "Di", "Wo", "Do", "Vr", "Za", "Zo" },
    // Les indices du 1:      0      1      2     3      4      5      6
                        { "Mo", "Tu", "We", "Th", "Fr", "Sa", "Su"}
    // Les indices du 2:      0      1      2     3      4      5      6
                    },
                    {
                        { "Lun", "Mar", "Mer", "Jeu", "Ven", "Sam", "Dim" },
    // Les indices du 0:      0      1      2     3      4      5      6
                        { "Maa", "Din", "Woe", "Don", "Vri", "Zat", "Zon" },
    // Les indices du 1:      0      1      2     3      4      5      6
                        { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"}
    // Les indices du 2:      0      1      2     3      4      5      6
                    },
                    {
                        { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" },
    // Les indices du 0:      0      1      2     3      4      5      6
                        { "Maandag", "Dinsdag", "Woensdag", "Donderdag", "Vrijdag", "Zaterdag", "Zondag" },
    // Les indices du 1:      0      1      2     3      4      5      6
                        { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saterday", "Sunday"}
    // Les indices du 2:      0      1      2     3      4      5      6
                    }
                };

            //Dire en Français que mon jour préféré est vendredi, car tout est permis...
            Console.WriteLine($"J'aime le {jourSemaineMultiFormat[2,0,4]}, car tout est permis!");
        }
    }
}
