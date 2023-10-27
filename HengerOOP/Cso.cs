using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HengerOOP
{
    public class Cso:Henger
    {
        double falVastagsag;

        public double FalVastagsag { get => falVastagsag; }

        public Cso(double sugar, double magassag, double falVastagsag) : base(sugar, magassag)
        {
            this.falVastagsag = falVastagsag;
        }

        public Cso(double sugar, double magassag) : this(sugar, magassag, 1)
        {
        }

        public Cso(double sugar, double magassag, double falVastagsag, double falVastagsagertek) : this(sugar, magassag, falVastagsag * falVastagsagertek)
        {
        }

        public override double Terfogat()
        {
            return base.Terfogat() - (3.14 * Math.Pow(GetSugar - falVastagsag, 2) * GetMagassag);
        }

        public override string ToString()
        {
            return base.ToString() + $"; falvastagsága: {falVastagsag}";
        }
    }
}