
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Models.Tests
{
    [TestClass]
    public class CarTests
    {
        [DataTestMethod]
        [DataRow(2017, 4)]
        [DataRow(2016, 5)]
        [DataRow(2000, 21)]


        //test age of car
        public void AgeOfCarTest(int yearOfCar, int expectedResult)
        {
            //Arrange
            Car car = new Car(yearOfCar, "", true);
            //Act
            int actualResult = car.Age;

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        //test echeck method
        [DataTestMethod]
        [DataRow(2012, false, false)]
        [DataRow(1993, false, false)]
        [DataRow(1997, false, true)]
        [DataRow(1996, false, false)]
        [DataRow(2012, true, false)]
        [DataRow(2017, false, true)]
        [DataRow(-1, false, false)]
        [DataRow(-1, true, false)]
        public void DoesCarNeedEcheckTest(int yearOfCar, bool isClassic, bool expectedResult)
        {
            //Arrange
            Car car = new Car(0,"",false);

            //Act
            bool actualResult = car.NeedsEcheck(yearOfCar, isClassic);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
