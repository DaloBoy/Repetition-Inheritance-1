using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_Inheritance
{
    public class DieselBil : Bil
    {
        public bool PartikkelFilter { get; set; }
        public DieselBil(string Mærke, double PrisExAfgift, int KøbsÅr, int KmPrLiter, string RegistreringsNr, int Tank, bool PartikelFilter) 
            : base(Mærke, PrisExAfgift, KøbsÅr, KmPrLiter, RegistreringsNr)
        {
            this.PartikelFilter = PartikelFilter;
            this.Tank = Tank;
        }
        
        public DieselBil(string Mærke, double PrisExAfgift, int KøbsÅr, int KmPrLiter, string RegistreringsNr, int Tank) 
            : this(Mærke, PrisExAfgift, KøbsÅr, KmPrLiter, RegistreringsNr, Tank, PartikelFilter: true)
        {

        }

        

        public bool PartikelFilter  { get; set; }

        public int Tank { get; set; }

        
        public override int HalvÅrligEjerafgift()
        {

            int ejerafgift = 0;

            if (KmPrLiter < 5)
            {
                throw new HalvÅrligEjerAfgiftException();
            }
            if (KmPrLiter < 15)
            {
                ejerafgift = 2000;
            }
            else if (KmPrLiter >= 15 || KmPrLiter <= 25)
            {
                ejerafgift = 1000;
            }
            if (KmPrLiter > 25)
            {
                ejerafgift = 350;
            }

            
            if (PartikelFilter == false)
            {
                ejerafgift += 500;
            }
            return ejerafgift;
        }
        
        public override int Rækkevidde()
        {
            int række = Tank * KmPrLiter;
            return række;
        }
    }
}
