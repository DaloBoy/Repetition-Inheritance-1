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
        public DieselBil(string Mærke, double PrisExAfgift, int KøbsÅr, int KmPrLiter, string RegistreringsNr, bool PartikelFilter) : base(Mærke, PrisExAfgift, KøbsÅr, KmPrLiter, RegistreringsNr)
        {
            this.PartikelFilter = PartikelFilter;
        }

        public DieselBil(string Mærke, double PrisExAfgift, int KøbsÅr, int KmPrLiter, string RegistreringsNr) 
            : this(Mærke, PrisExAfgift, KøbsÅr, KmPrLiter, RegistreringsNr, PartikelFilter: true)
        {

        }

        

        public bool PartikelFilter  { get; set; }

        
        public override int HalvÅrligEjerafgift()
        {
            int ejerafgift = base.HalvÅrligEjerafgift();
            if (PartikelFilter == false)
            {
                ejerafgift += 500;
            }
            return ejerafgift;
        }

        
        
    }
}
