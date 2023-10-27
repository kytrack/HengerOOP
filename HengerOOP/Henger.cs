using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HengerOOP
{
    public class Henger
    {
        private double magassag;
        private double sugar;
        private static int szuletesSzamlalo;

        public double GetMagassag { get => magassag; }
        public double GetSugar { get => sugar; }
        public static int SzuletesSzamlalo { get => szuletesSzamlalo; }

        public Henger(double sugar, double magassag)
        {
            this.sugar = sugar;
            this.magassag = magassag;
            szuletesSzamlalo++;
        }

        public virtual double Terfogat()
        {
            return 3.14 * Math.Pow(sugar, 2) * magassag;
        }

        public override string ToString()
        {
            return $"Jellemzők >> térfogat: {Math.Round(Terfogat(), 2)}; sugár: {sugar}; magasság: {magassag};";
        }
    }





}