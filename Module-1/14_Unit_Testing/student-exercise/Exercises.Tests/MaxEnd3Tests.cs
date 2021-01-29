using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Tests
    {
        [TestMethod]
        public void Check_First_Index_Make_New_Array_With_Bigger_Number()
        {
            //Arrange
            MaxEnd3 testMethod = new MaxEnd3();
            int[] array1 = new int[] { 11, 5, 8 };
            int[] expectedArray = new[] { 11, 11, 11 };

            //Act
            int[] resultArray = testMethod.MakeArray(array1);


            //Assert
            CollectionAssert.AreEqual(expectedArray, resultArray);



        }
        public void Check_Last_Index_Make_New_Array_With_Bigger_Number()
        {
            //Arrange
            MaxEnd3 testMethod = new MaxEnd3();
            int[] array1 = new int[] { 0, 5, 11 };
            int[] expectedArray = new[] { 11, 11, 11 };

            //Act
            int[] resultArray = testMethod.MakeArray(array1);


            //Assert
            CollectionAssert.AreEqual(expectedArray, resultArray);



        }
        public void First_Index_And_Last_Index_Are_Same()
        {
            //Arrange
            MaxEnd3 testMethod = new MaxEnd3();
            int[] array1 = new int[] {0, 5, 0};
            int[] expectedArray = new[] { 0, 0, 0 };

            //Act
            int[] resultArray = testMethod.MakeArray(array1);


            //Assert
            CollectionAssert.AreEqual(expectedArray, resultArray);



        }
    }
}
