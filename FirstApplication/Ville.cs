using System;
namespace FirstApplication
{
    public class Ville
    {
        private String nom;
        private int x;
        private int y;

        public Ville()
        {}
        //constructor
        public Ville (string nom, int x, int y)

         {
                this.nom = nom;
                this.x = x;
                this.y = y; 
         }

        public String NomVille
        {
        get
            {
               return nom;
            }
        set
            {
                value = nom;
            }
        }

        public int xFunction
        {
            get
            {
                return x;
            }
            set
            {
               value = x;
            }
        }

        public int yFunction
        {
            get
            {
                return y;
            }
            set
            {
                value = y;
            }
        }

       
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(this.GetType()))
            {
                return false;
            }
            else
            {
                Ville ville = (Ville)obj;
                return (this.nom.Equals(ville.nom) && this.x == ville.x && this.y == ville.y);
            }
        }
        
    }
}