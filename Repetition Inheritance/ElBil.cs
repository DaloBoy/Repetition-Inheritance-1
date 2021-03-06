﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_Inheritance
{
    public class ElBil : Bil, IElMotor
    {
        public ElBil(string Mærke, double PrisExAfgift, int KøbsÅr, string RegistreringsNr, int BatteryKapacitet, int KmPrKW) : base(Mærke, PrisExAfgift, KøbsÅr, RegistreringsNr)
        {
            this.BatteryKapacitet = BatteryKapacitet;
            this.KmPrKW = KmPrKW;
        }

        public int BatteryKapacitet { get; set; }
        public int KmPrKW  { get; set; }

        public override int HalvÅrligEjerafgift()
        {
            return 0;
        }

        public int LadeTid()
        {
            return 5;
        }

        public override double RegistreringsAfgift()
        {
            double regafgift = 0;
            if (KøbsÅr <= 2014)
            {
                if (BilPrisExAfgift <= 80500)
                {
                    regafgift = (BilPrisExAfgift*1.05);
                }
                if (BilPrisExAfgift > 80500)
                {
                    regafgift = (BilPrisExAfgift*1.8);
                }
            }
            if (KøbsÅr >= 2015)
            {
                if (BilPrisExAfgift <= 81700)
                {
                    regafgift = (BilPrisExAfgift*1.05);
                }
                if (BilPrisExAfgift > 81700)
                {
                    regafgift = (BilPrisExAfgift*1.8);
                }
            }
            regafgift = regafgift*0.2;
            return regafgift;
        }

        public override int Rækkevidde()
            {
                return BatteryKapacitet*KmPrKW;
            }
    }
}
