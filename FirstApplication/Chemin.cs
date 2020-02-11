using System;
using System.Collections.Generic;
namespace FirstApplication
{
    public class Chemin
    {

        private List<Ville> villes;
        private double score;


        public Chemin(List<Ville> Ville)
        {
            this.villes = Ville;
        }


        public double getScore()
        {
            int nbVilles = villes.Count;
            double score = 0;
            for (int i = 0; i < nbVilles - 1; i++)
            {
                Ville ville1 = villes[i];
                Ville ville2 = villes[i + 1];
                double Xtotal = Math.Abs(ville1.xFunction - ville2.xFunction);
                double Ytotal = Math.Abs(ville1.yFunction - ville2.yFunction);
                double calcul = Math.Sqrt(Math.Pow(Xtotal, 2) + Math.Pow(Ytotal, 2));
                score += calcul;

            }
            return score;
        }

        public List<Ville> GetVilles()
        {
            return villes;
        }



    }
}
