using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repetition_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_Inheritance.Tests
{
    [TestClass()]
    public class DieselBilTests
    {
        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_DiselBil_udenPartikel()
        {
            //Arange
            Bil Dbil = new DieselBil("Skoda", 0, 2004, 10, "w4h4h5h4", 6, false);

            //Act
            Dbil.HalvÅrligEjerafgift();

            //Assert
            Assert.AreEqual(2500, Dbil.HalvÅrligEjerafgift());
        }
        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Dieselbil_medPartikel()
        {
            //Arange
            Bil Dbil = new DieselBil("Skoda", 300000, 2004, 10, "w4h4h5h4", 6);

            //Act
            Dbil.HalvÅrligEjerafgift();

            //Assert
            Assert.AreEqual(2000, Dbil.HalvÅrligEjerafgift());
        }
        
        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_Elbil()
        {
            //Arange
            Bil Elbil = new ElBil("BMW", 250000, 2010, "3D2S", 10, 20);

            //Act
            Elbil.HalvÅrligEjerafgift();

            //Assert
            Assert.AreEqual(0, Elbil.HalvÅrligEjerafgift());
        }
        [TestMethod()]
        public void HalvÅrligEjerafgiftTest_BenzinBil()
        {
            //Arange
            Bil Bbil = new BenzinBil("Porche", 240000, 2004, 10, "b8um5r", 3);

            //Act
            Bbil.HalvÅrligEjerafgift();

            //Assert
            Assert.AreEqual(1200, Bbil.HalvÅrligEjerafgift());
        }
        
        [TestMethod()]
        [ExpectedException(typeof(HalvÅrligEjerAfgiftException))]
        public void HalvÅrligEjerafgiftTest_DieselExTest()
        {
            //Arange
            Bil Dbil = new DieselBil("Kia", 1500000, 2013, 4, "jt6tyrj", 4);

            //Act
            Dbil.HalvÅrligEjerafgift();

            //Assert
            Assert.AreEqual(2000, Dbil.HalvÅrligEjerafgift());
        }
    }
}