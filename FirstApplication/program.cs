using System;
using System.Collections.Generic;
namespace FirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Ville ville1 = new Ville("toulouse", 10, 4);
            Ville ville2 = new Ville("nice", 20, 14);
            Ville ville3 = new Ville("toulon", 10, 24);

            //create a list
            List<Ville> villes = new List<Ville>();
            // Add items using Add method   
            villes.Add(ville1);
            villes.Add(ville2);
            villes.Add(ville3);
            Chemin Chemin = new Chemin(villes);
            Console.WriteLine("score =" +Chemin.getScore());

            Generation G1 = new Generation();
            G1.getFirstGen(6,villes);


        }
    }
}
