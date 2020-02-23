using System;
using System.Collections.Generic;
namespace FirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Ville ville1 = new Ville("Nice",  642 , 863);
            Ville ville2 = new Ville("Saint-laurent", 765, 254);
            Ville ville3 = new Ville("Cagnes-sur-mer", 206, 475);
            Ville ville4 = new Ville("Biot", 874, 452);
            Ville ville5 = new Ville("Antibes", 345, 345);
            Ville ville6 = new Ville("Mougins", 453, 543);
            Ville ville7 = new Ville("Grasse", 437, 938);
            Ville ville8 = new Ville("Cannes", 65, 243);
            Ville ville9 = new Ville("Valbonne", 234, 976);
            Ville ville10 = new Ville("Menton", 432, 635);


            //create a list
            List<Ville> villes = new List<Ville>();
            // Add items using Add method   
            villes.Add(ville1);
            villes.Add(ville2);
            villes.Add(ville3);
            villes.Add(ville4);
            villes.Add(ville5);
            villes.Add(ville6);
            villes.Add(ville7);
            villes.Add(ville8);
            villes.Add(ville9);
            villes.Add(ville10);


            Generateur g1 = new Generateur();
            //Generer 10 chemins
            List<Chemin> chemins = g1.GenererChemins(10, villes);
            Console.WriteLine("***** Chemins générés***** ");
            Console.WriteLine(String.Join("\n \n", chemins));

            //Mutation
            List<Chemin>cheminsModifies = g1.Echanger(chemins, 2);
            Console.WriteLine("\n \n *****liste des chemins modifiés*****");
            Console.WriteLine(String.Join("\n", cheminsModifies));

            //xover
            List<Chemin> cheminsXover = g1.GenererXOver(chemins, 2, 2);
            Console.WriteLine("\n \n *****Chemins générés par le xover*****");
            Console.WriteLine(String.Join("\n", cheminsXover));


        }
    }
}
