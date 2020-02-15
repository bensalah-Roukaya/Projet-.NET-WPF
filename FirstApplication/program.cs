using System;
using System.Collections.Generic;
namespace FirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Ville ville1 = new Ville("toulouse",  10 , 4);
            Ville ville2 = new Ville("nice", 20, 14);
            Ville ville3 = new Ville("toulon", 0, 24);
            Ville ville4 = new Ville("Bordeaux", 0, 24);


            //create a list
            List<Ville> villes = new List<Ville>();
            // Add items using Add method   
            villes.Add(ville1);
            villes.Add(ville2);
            villes.Add(ville3);
            villes.Add(ville4);


            Generateur g1 = new Generateur();
            //Generer 4 chemins
            List<Chemin> chemins = g1.GenererChemins(4,villes);
            Console.WriteLine("***** Chemins générés***** ");
            Console.WriteLine(String.Join("\n \n", chemins));

            List<Ville> villesModifiees = g1.Echanger(villes, 1, 2);
            Console.WriteLine("\n \n *****liste de villes originales*****");
            Console.WriteLine(String.Join("\n", villes));
            Console.WriteLine("\n \n *****liste de villes modifiées*****");
            Console.WriteLine(String.Join("\n", villesModifiees));

            List<Chemin> cheminsXover = g1.genererXOver(chemins, 2, 2);
            Console.WriteLine("\n \n *****Chemins générés par le xover*****");
            Console.WriteLine(String.Join("\n", cheminsXover));


        }
    }
}
