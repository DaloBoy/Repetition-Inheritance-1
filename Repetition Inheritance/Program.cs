using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DieselBil> dieselBils = new List<DieselBil>();
            dieselBils.Add(new DieselBil("BMW", 200000, 2006, 10, "23r23r", 69));
            dieselBils.Add(new DieselBil("Porche", 800000, 2015, 32,"hewh45h", 7));
            dieselBils.Add(new DieselBil("Skoda", 300000, 2004, 20,"w4h4h5h4", 6, false));
            dieselBils.Add(new DieselBil("Kia", 1500000, 2013, 15,"jt6tyrj", 10));
            dieselBils.Add(new DieselBil("Lamboghini", 2000000, 2014, 26,"gw54g4g", 8, false));

            List<BenzinBil> benzinBils = new List<BenzinBil>();
            benzinBils.Add(new BenzinBil("BMW", 200000, 2004, 10, "q3t87gh", 9));
            benzinBils.Add(new BenzinBil("Porche", 240000, 2004, 20, "b8um5r", 3));
            benzinBils.Add(new BenzinBil("Skoda", 80000, 2004, 29, "mvw9wv4", 122));
            benzinBils.Add(new BenzinBil("Kia", 740000, 2004, 15, "9wmvw4v", 8));
            benzinBils.Add(new BenzinBil("Lamboghini", 1400000, 2004, 9, "a9je4rv", 5));

            foreach (DieselBil biler in dieselBils)
            {
                Console.WriteLine("Mærke: "  + biler.Mærke  +   "   Bilens pris er: " + biler.BilPrisExAfgift    +    "   Købt: "   + biler.KøbsÅr   +   "    RegistreringNr: "  +  biler.RegistreringsNr + "     Den halvårlige ejerafgift er: "  + biler.HalvÅrligEjerafgift()  + " Rækkevidde: " + biler.Rækkevidde());
            }

            Console.WriteLine("==========================");
            
            foreach (BenzinBil benzin in benzinBils)
            {
                Console.WriteLine("Mærke: "  + benzin.Mærke  +   "   Bilens pris er: " + benzin.BilPrisExAfgift    +    "   Købt: "   + benzin.KøbsÅr   +   "    RegistreringNr: "  +  benzin.RegistreringsNr + "     Den halvårlige ejerafgift er: "  + benzin.HalvÅrligEjerafgift()  + " Rækkevidde: " + benzin.Rækkevidde());

            }
            Console.ReadLine();
        }
    }
}
