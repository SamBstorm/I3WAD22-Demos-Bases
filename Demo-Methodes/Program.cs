using System;
using System.Collections.Generic;

namespace Demo_Methodes
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConsoleAvancee ca;
            //Coordonnee c1;
            //c1.x = 1;
            //c1.y = 1;

            //ca.RainbowWriteLine($"Ma première coordonnée est située en : {c1.ShowXY()}");
            //Coordonnee c2 = new Coordonnee();

            //ca.RainbowWrite($"Ma seconde coordonnée est située en : {c2.ShowXY()}");
            //Console.WriteLine();

            //Geometry g;
            //g.QuelleForme(6,4,7,1);

            Presence wad = new Presence();
            wad.SetClass("Sara", "Alessandra", "Menen", "Nastya", "Maya", "Kasia", "Eleonore", "Camille", "Anissa");
            wad.StudentHere("Sara");
            wad.StudentHere("Paula");
            wad.StudentHere("Anissa");
            wad.StudentHere("Kasia");
            wad.StudentHere("Elonore");
            int nbStudent;
            if(wad.CheckCanBeginLesson(out nbStudent))
            {
                Console.WriteLine($"On peut commencer le cours, elles sont {nbStudent} en classe");
            }
            else
            {
                Console.WriteLine($"On ne peut pas commencer le cours, elles ne sont que {nbStudent} en classe");
            }
        }
    }

    public struct Coordonnee
    {
        public int x, y;
        /// <summary>
        /// Récupère les coordonnées sous format texte.
        /// </summary>
        /// <returns></returns>
        public string ShowXY()
        {
            return $"X {this.x} - Y {this.y}";
        }
    }
    /// <summary>
    /// Ensemble de fonctions supplémentaire pour la console.
    /// </summary>
    public struct ConsoleAvancee
    {
    /// <summary>
    /// Permet d'écrire un texte avec des couleur pour chaque caractère.
    /// </summary>
    /// <param name="text">Texte qui sera affiché.</param>
        public void RainbowWrite(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                Console.ForegroundColor = (ConsoleColor)((i % 6) + 9);
                Console.Write(c);
            }
            Console.ResetColor();
        }

        public void RainbowWriteLine(string text)
        {
            this.RainbowWrite(text);
            Console.WriteLine();
        }
    }

    public struct Geometry { 
        public void QuelleForme()
        {
            Console.WriteLine("Aucune spécification c'est une forme quelconque.");
        }

        public void QuelleForme(int distance1)
        {
            Console.WriteLine($"Une distance enregistrée : {distance1} cm ; C'est une droite.");
        }


        public void QuelleForme(int distance1, int distance2, int distance3)
        {
            Console.WriteLine($"Trois distances enregistrées : \n{distance1} cm ,\n {distance2} cm,\n{distance3} cm;\n C'est un triangle.");
        }
        public void QuelleForme(int distance1, int distance2, int distance3, int distance4)
        {
            Console.WriteLine($"Quatre distances enregistrées : \n{distance1} cm ,\n {distance2} cm,\n{distance3} cm,\n{distance4} cm;\n C'est un quadrilatère.");
        }

        //public void QuelleForme(params int[] distances)
        //{
        //    switch (distances.Length)
        //    {
        //        case 0: Console.WriteLine("Quelconque"); break;
        //        case 1: Console.WriteLine("Ligne"); break;
        //        case 3: Console.WriteLine("Triangle"); break;
        //        case 4: Console.WriteLine("Quadrialtère"); break;
        //        case 5: Console.WriteLine("Pentagone"); break;
        //        default:
        //            Console.WriteLine("Forme non définie");
        //            break;
        //    }
        //}
    }

    public struct Presence
    {
        List<string> students;
        List<bool> areHere;

        public void SetClass(params string[] names)
        {
            students = new List<string>();
            areHere = new List<bool>();
            foreach (string name in names)
            {
                students.Add(name);
                areHere.Add(false);
            }
        }

        public void StudentHere(string name)
        {
            if (!students.Contains(name)) return;
            int index = students.IndexOf(name);
            areHere[index] = true;
        }

        public bool CheckCanBeginLesson(out int nbStudentHere)
        {
            nbStudentHere = 0;
            foreach (bool isHere in this.areHere)
            {
                if (isHere) nbStudentHere++;
            }
            return nbStudentHere * 2 >= students.Count;
        }
    }
}
