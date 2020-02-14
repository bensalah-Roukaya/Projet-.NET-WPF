using System;
using System.Diagnostics.CodeAnalysis;

namespace FirstApplication
{
    public class Ville : IEquatable<Ville>
    {
        public String Nom { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Ville(string nom, int x, int y)
        {
            this.Nom = nom;
            this.X = x;
            this.Y = y;
        }
        public bool Equals([AllowNull] Ville other)
        {
            return
              this.Nom.Equals(other.Nom) &&
              this.X.Equals(other.X) &&
              this.Y.Equals(other.Y);
        }

        public override String ToString()
        {
            return $"Nom:{Nom}, X:{X}, Y:{Y}";
        }
    }
}