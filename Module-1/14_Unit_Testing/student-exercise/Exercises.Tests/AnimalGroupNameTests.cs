using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTests
    {

        [DataTestMethod]
        [DataRow(null, "unknown")]
        [DataRow("", "unknown")]
        [DataRow("elephant", "Herd")]
        [DataRow("elephants", "unknown")]
        [DataRow("FlAmInGo", "Pat")]
        [DataRow("dsggsdgasdgasrewrdf", "unknown")]

        public void Input_Animal_Name_Return_Herd(string animalName, string herdName)
        {

            //Arrange
            AnimalGroupName animalDictionary = new AnimalGroupName();


            //Act
            string resultHerdName = animalDictionary.GetHerd(animalName);
            


            //Asser
            Assert.AreEqual(herdName, resultHerdName);


        }
       

    }
}
