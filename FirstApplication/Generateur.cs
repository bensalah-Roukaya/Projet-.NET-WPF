using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstApplication
{
    public class Generateur
    {
        Random rnd = new Random();// mettre le Random en dehors de la fonction

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
        public List<Chemin> genererXOver(List<Chemin> chemins, int pivot, int coefficient)
        {
            // chemin affiché 2 fois dans --> réxecuter
            // rajouter un test pour que le pivot ne soit pas superieur au nombre de ville de chemin
            // Faut faire une boucle pour faire fonctionnéé le x over plusieurs fois
            List<Chemin> resultat = new List<Chemin>();


            for (int i = 0; i < coefficient * chemins.Count; i++)
            {
                int indexChemin1;
                int indexChemin2;
                Chemin ch;

                do
                {
                    List<Ville> villesXover = new List<Ville>();
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

                    ch = new Chemin(villesXover);
                }
                while (ch.ContientDoublons());
                resultat.Add(ch);
            }
            return resultat;
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

        public List<Chemin> Elite(List<Chemin> chemins, int nbElite)
        {
            List<Chemin> eliteChemin = new List<Chemin>();


            return null;
        }

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
