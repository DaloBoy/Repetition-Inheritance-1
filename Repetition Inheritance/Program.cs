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
            dieselBils.Add(new DieselBil("BMW", 5000, 2006, 32, "23r23r"));
            dieselBils.Add(new DieselBil("Porche", 4700, 2015, 32,"hewh45h"));
            dieselBils.Add(new DieselBil("Skoda", 3900, 2004, 32,"w4h4h5h4", false));
            dieselBils.Add(new DieselBil("Kia", 6300, 2013, 32,"jt6tyrj"));
            dieselBils.Add(new DieselBil("Lamboghini", 7600, 2014, 32,"gw54g4g", false));

            foreach (DieselBil biler in dieselBils)
            {
                Console.WriteLine("RegistreringNr:"  +  biler.KøbsÅr + "     Den halvårlige ejerafgift er: "  + biler.HalvÅrligEjerafgift());
            }
            Console.ReadLine();

        }
    }
}
