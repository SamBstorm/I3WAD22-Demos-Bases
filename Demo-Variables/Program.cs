using System;

namespace Demo_Variables
{
    class Program
    {
        // Variable membre / Champs : variable déclarée dans une class ou une struct
        double racineCarreDeDeux = 1.41;
        static void Main(string[] args)
        {
            //Toutes variables dans la méthode sont des variables locales
            int unEntier;   //Déclaration : création d'une zone mémoire dans le stack
            unEntier = 42;  //Initialisation : affectation de la première valeur d'une variable
                            //                  Si variable structurelle, défini dans le Stack
                            //                  Si variable référentielle, défini dans le Heap
            bool estAllume = true;   //Déclaration et initialisation en même temps (obligatoire pour les constantes)
            char caractere1, caractere2, caractere3; // Déclaration multiple : des variables d'un même type peuvent être déclaré en une seule ligne.

            //Déclaration et initialisation multiple : MAUVAISE PRATIQUE car compliqué à la lecture...
            short petit1 = 1, petit2 = 2, petit3;

            //Une constante est une variable (membre ou locale) qui doit être initialisée et dont la valeur ne change jamais!
            const string MEILLEUR_PROF = "Samuel";

            /*
             DIFFÉRENTS FORMAT DE NOMMAGE :
            
             UpperCamelCase : Pour les object complexe (class, struct, méthode, ...)
             lowerCamelCase : Pour les variables
             UPPER_CASE : Pour les constantes
             
             Caractères autorisés alphanumérique + _ sauf pour le premier caractère qui ne peut pas être un  nombre
             _toto => OK
             unCaractere => OK
             1caractere => KO
             */
        }
    }
}
