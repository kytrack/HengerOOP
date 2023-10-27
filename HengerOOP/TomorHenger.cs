using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HengerOOP
{
    public class TomorHenger : Henger
    {
        private double fajsuly;

        public double GetFalysuly { get => fajsuly; }
        public double Suly { get => fajsuly*Terfogat(); }

        public TomorHenger(double sugar, double magassag, double fajsuly) : base(sugar, magassag)
        {
            this.fajsuly = fajsuly;
        }

        public TomorHenger(double sugar, double magassag) : this(sugar, magassag, 7.87)
        {
        }

        public override string ToString()
        {
            return base.ToString() + $" fajsúly {fajsuly} ";
        }

    }
}