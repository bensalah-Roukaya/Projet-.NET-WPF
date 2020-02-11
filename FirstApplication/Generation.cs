using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApplication
{
    public class Generation
    {
        public Generation()
        {

        }

       public List<Chemin> getFirstGen(int nb, List<Ville> villes)
        {
            List<Chemin> chemins = new List<Chemin>();
            if (nb <= factoriel(villes.Count))
            { 
            for (int i = 0; i < nb; i++)
                {
                    chemins.Add(new Chemin(melanger(villes)));
            }
            }           


                 else
                 {
                     Console.WriteLine("erreur: le nombre de combinaisons possibles " +
                         "est inferieur au nombre de combinaisons demandé");
                 }
                 return chemins;
        }

        List<Ville> melanger(List<Ville> villes)
        {
            List<Ville> villesMelangees = new List<Ville>();
            villesMelangees = villes.OrderBy(a => Guid.NewGuid()).ToList();
            return villesMelangees;

        }

       Boolean comparer(Chemin cheminA, Chemin cheminB)
        {
            Boolean areEqual = false;

            if (cheminA.GetVilles().Count == cheminB.GetVilles().Count)
            {
                for (int i = 0; i < cheminA.GetVilles().Count; i++)
                {
                    if (cheminA.GetVilles()[i] == cheminB.GetVilles()[i])   
                    {
                        areEqual = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("erreur: les nombres des villes des deux chemins ne sont pas égaux");
            }
            return areEqual;
        }

        // fonction factoriel
        int factoriel(int nombre)
        {
            int f = 1;
            for (int i = nombre; i < 0; i--)
            {
                f = f * i;
            }
            return f;
        }
    }
}
