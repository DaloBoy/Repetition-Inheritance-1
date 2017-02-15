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
    public class BilTests
    {
        [TestMethod()]
        public void RegistreringsAfgiftTest_80500_2014()
        {
            // arrange
            Bil bil = new DieselBil("BMW", 80500, 2014, 10, "23r23r", 69);  
            
            //act
            bil.RegistreringsAfgift();
            
            // assert
                                      
            Assert.AreEqual(84525, bil.RegistreringsAfgift());

        }

        [TestMethod()]

        public void RegistreringsAfgift_80499_2014()
        {
            // arrange
            Bil bil = new DieselBil("Kia", 80499, 2014, 15,"jt6tyrj", 10);

            //act 
            bil.RegistreringsAfgift();

            //assert
            Assert.AreEqual(84523,95, bil.RegistreringsAfgift());
        }

        [TestMethod()]

        public void RegistreringsAfgiftElbil_80500_2014()
        {
            //arrange
            Bil Elbil = new ElBil("Nissan", 80500, 2014, "4D2W", 5, 50);
            //act
            Elbil.RegistreringsAfgift();
            //assert
            Assert.AreEqual(16905, Elbil.RegistreringsAfgift());
        }
        [TestMethod()]

        public void RegistreringsAfgiftElbil_81700_2015()
        {
            //arrange
            Bil Elbil = new ElBil("cheveolet", 81700, 2017, "8Y5C", 10, 23);
            //act
            Elbil.RegistreringsAfgift();
            //assert
            Assert.AreEqual(17157, Elbil.RegistreringsAfgift());
        }
        [TestMethod()]

        public void RegistreringsAfgift_81700_2015()
        {
            //arrange
            Bil bil = new DieselBil("BMW", 81700, 2015, 10, "23r23r", 69);
            //act
            bil.RegistreringsAfgift();
            //assert
            Assert.AreEqual(85785, bil.RegistreringsAfgift());
        }
        [TestMethod()]

        public void RegistreringsAfgift_82000_2015()
        {
            //arrange
            Bil bil = new DieselBil("BMW", 82000, 2015, 10, "23r23r", 69);
            //act
            bil.RegistreringsAfgift();
            //assert
            Assert.AreEqual(147600, bil.RegistreringsAfgift());
        }
        [TestMethod()]

        public void RegistreringsAfgift_81000_2014()
        {
            //arrange
            Bil bil = new DieselBil("BMW", 81000, 2014, 10, "23r23r", 69);
            //act
            bil.RegistreringsAfgift();
            //assert
            Assert.AreEqual(145800, bil.RegistreringsAfgift());
        }
        [TestMethod()]

        public void RegistreringsAfgiftElbil_81000_2014()
        {
            //arrange
            Bil Elbil = new ElBil("cheveolet", 81000, 2014, "8Y5C", 10, 23);
            //act
            Elbil.RegistreringsAfgift();
            //assert
            Assert.AreEqual(29160, Elbil.RegistreringsAfgift());
        }
        [TestMethod()]

        public void RegistreringsAfgiftElbil_82000_2015()
        {
            //arrange
            Bil Elbil = new ElBil("cheveolet", 82000, 2015, "8Y5C", 10, 23);
            //act
            Elbil.RegistreringsAfgift();
            //assert
            Assert.AreEqual(29520, Elbil.RegistreringsAfgift());
        }
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        
        public void RegistreringsAfgiftTestexception()
        {
            // arrange
            Bil bil = new DieselBil("BMW", 0, 2010, 10, "23r23r", 69);

            //act
            bil.RegistreringsAfgift();

            // assert

            Assert.AreEqual(84525, bil.RegistreringsAfgift());

        }
    }

}