using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApplication
{
    public class Generateur
    {
        public Generateur()
        {
        }

        /*
         * Générer une liste des chemins à partir d'une liste des villes
         */
        public List<Chemin> GenererChemins(int nbGeneration, List<Ville> villes)
        {
            List<Chemin> chemins = new List<Chemin>();
            if (nbGeneration <= factoriel(villes.Count))
            {
                int i = 0;
                do
                {
                    var nouveauChemin = new Chemin(melanger(villes));
                    if (!chemins.Contains(nouveauChemin))
                    {
                        chemins.Add(nouveauChemin);
                        i++;

                    }
                } while (i < nbGeneration);

            }
            else
            {
                throw new System.ArgumentException("erreur: le nombre de combinaisons possibles " +
                    "est inferieur au nombre de combinaisons demandées");
            }
            return chemins;
        }

        /**
         * Mélanger aleatoirement une liste des villes
         */
        List<Ville> melanger(List<Ville> villes)
        {
            List<Ville> villesMelangees = new List<Ville>();
            villesMelangees = villes.OrderBy(a => Guid.NewGuid()).ToList();
            return villesMelangees;

        }

        /*
         * 
         */
        Random rnd = new Random();// mettre le Random en dehors de la fonction
        public Chemin genererXOver(List<Chemin> chemins, int pivot, int nombreXover)
        {
            // ville affiché 2 fois dans le meme chemin(eliminé une)
            // rajouter un test pour que le pivot ne soit pas superieur au nombre de ville de chemin
            // Faut faire une boucle pour faire fonctionnéé le x over plusieurs fois
            List<Ville> villesXover = new List<Ville>();

            int indexChemin1;
            int indexChemin2;
            do
            {
                //choisir deux chemins aléatoirement de la liste
                indexChemin1 = rnd.Next(chemins.Count);
                indexChemin2 = rnd.Next(chemins.Count);
            }
            while (indexChemin1 == indexChemin2);

            int tailleVilleXover = chemins[indexChemin1].Villes.Count;
            var nPremieresVilles = chemins[indexChemin1].Villes.Take(pivot);

            var nSecondesVilles = chemins[indexChemin2].Villes.Skip(Math.Max(0, tailleVilleXover - pivot));
            villesXover.AddRange(nPremieresVilles);
            villesXover.AddRange(nSecondesVilles);

            return new Chemin(villesXover);
        }


        /*
         * Changement de position de deux villes dans une liste (mutation)
         */
        public List<Ville> Echanger(List<Ville> villes, int indexA, int indexB)
        {
            List<Ville> newlist = villes.ToList();
            if (villes.Count > indexB && villes.Count > indexA)
            {
                Ville tmp = villes[indexA];
                villes[indexA] = villes[indexB];
                villes[indexB] = tmp;
            }
            else
                throw new System.ArgumentException("erreur: au moins un index choisi est superieur au nombre de villes");

            return newlist;
        }

        //Elite function
        /*
        public List<Chemin> eliteFunction(List<Chemin> chemins)
        {
            foreach (Chemin item in chemins)
            {
                double maxScore = Math.Max(Chemin.getScore(), projection(item));
            }

        }*/

        // fonction factoriel
        private int factoriel(int nombre)
        {
            int f = nombre;
            for (int i = 1; i < nombre; i++)
            {
                f *= i;
            }
            return f;
        }
    }
}
