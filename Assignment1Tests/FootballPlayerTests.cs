using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {

        private FootballPlayer player = new FootballPlayer { Id = 1, Name = "Viktor", Age = 19, ShirtNumber = 8 };
        private FootballPlayer playerNameIsTooShort= new FootballPlayer { Id = 2, Name = "V", Age=20, ShirtNumber=9 };
        private FootballPlayer playerIsTooYoung= new FootballPlayer { Id = 3, Name = "Bonev", Age=0, ShirtNumber=10 };
        private FootballPlayer playerShirtNumberIsInvalid = new FootballPlayer { Id = 4, Name = "Viktor Bonev", Age = 21, ShirtNumber = 100 };


        //public void ToStringTest()
        //{
        //    string str = player.ToString();
        //    Assert.AreEqual("1 Viktor 19 8", str);
        //}

        [TestMethod()]
        public void ValidateNameTest()
        {
            player.ValidateName();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerNameIsTooShort.ValidateName());
        }

        [TestMethod()]
        public void ValidateAgeTest()
        {
            player.ValidateAge();
            Assert.ThrowsException<ArgumentException>(()=>playerIsTooYoung.ValidateAge());
        }

        [TestMethod()]
        public void ValidateShirtNumberTest()
        {
            player.ValidateShirtNumber();
            Assert.ThrowsException<ArgumentException>(()=>playerShirtNumberIsInvalid.ValidateShirtNumber());
        }

        [TestMethod()]
        public void ValidateTest()
        {
            player.Validate();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerNameIsTooShort.ValidateName());
            Assert.ThrowsException<ArgumentException>(() => playerIsTooYoung.ValidateAge());
            Assert.ThrowsException<ArgumentException>(() => playerShirtNumberIsInvalid.ValidateShirtNumber());  
        }
    }
}