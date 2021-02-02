using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTests
    {
        [DataTestMethod]
        [DataRow(new string[] { "ba", "ba", "black", "sheep" }, new string[] { "ba", "black", "sheep" }, new int[] { 2, 1, 1 })]
        [DataRow(new string[] { "a", "b", "a", "c", "b" }, new string[] { "a", "b", "c" }, new int[] { 2, 2, 1 })]
        [DataRow(new string[] { "c", "b", "a" }, new string[] { "c", "b", "a" }, new int[] { 1, 1, 1 })]
        [DataRow(new string[] { "fart", "sandwich", "poo", "fart", "poo", }, new string[] { "fart", "sandwich", "poo" }, new int[] { 2, 1, 2 })]
        [DataRow(new string[] { "a", null, "a", "c" }, new string[] { "a", "c" }, new int[] { 2, 1 }, DisplayName = "One of the strings in words is null")]
        [DataRow(new string[] { "a", null, null, null }, new string[] { "a" }, new int[] { 1 }, DisplayName = "Three of the strings in words is null")]
        [DataRow(new string[] { null, null, null, null }, new string[] { }, new int[] { }, DisplayName = "all of the strings in words is null")]
        [DataRow(null, new string[] { }, new int[] { }, DisplayName = "the array of words IS null")]


        public void GetCountTest(string[] words, string[] expectedDictKeys, int[] expectedDictValues)
        {
            //arrange
            WordCount wc = new WordCount();

            //act
            Dictionary<string, int> resultDict = wc.GetCount(words);
            string[] resultKeys = resultDict.Keys.ToArray();
            int[] resultValues = resultDict.Values.ToArray();

            //assert
            CollectionAssert.AreEquivalent(expectedDictKeys, resultKeys);
            CollectionAssert.AreEquivalent(expectedDictValues, resultValues);

        }


    }
}
