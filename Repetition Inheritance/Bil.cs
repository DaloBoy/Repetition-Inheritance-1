﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_Inheritance
{
   public abstract class Bil
    {

        public double BilPrisExAfgift { get; private set; }
        public int KøbsÅr { get; private set; }
        public string Mærke { get; set; }
        public string RegistreringsNr { get; set; }
        public int KmPrLiter { get; set; }

        public virtual double RegistreringsAfgift()
        {
            double regafgift = 0;
            if (KøbsÅr <= 2014)
            {
                if (BilPrisExAfgift <= 80500)
                {
                    regafgift = (BilPrisExAfgift*1.05)/100;
                }
                if (BilPrisExAfgift > 80500)
                {
                    regafgift = (BilPrisExAfgift*1.8)/100;
                }
            }
            if (KøbsÅr >= 2015)
            {
                if (BilPrisExAfgift <= 81700)
                {
                    regafgift = (BilPrisExAfgift * 1.05) / 100;
                }
                if (BilPrisExAfgift > 81700)
                {
                    regafgift = (BilPrisExAfgift * 1.8) / 100;
                }
            }
            return regafgift;
        }

        public double TotalPris()
        {
            return BilPrisExAfgift + RegistreringsAfgift();
        }

        public abstract int HalvÅrligEjerafgift();
        

        public Bil(string Mærke, double PrisExAfgift, int KøbsÅr, int KmPrLiter, string RegistreringsNr)
        {
            this.BilPrisExAfgift = PrisExAfgift;
            this.KmPrLiter = KmPrLiter;
            this.Mærke = Mærke;
            this.KøbsÅr = KøbsÅr;
            this.RegistreringsNr = RegistreringsNr;
        }

        public abstract int Rækkevidde();
        


    }
}
