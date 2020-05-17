using NUnit.Framework;
using System.Collections.Generic;
using CoverletDemo;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Calculation_Sum_2_Items()
        {
            var arrayOfNumbers = new List<int>() { 1, 5, 4 };

            var objCalculation = new Calculation();

            var result = objCalculation.Sum(arrayOfNumbers);

            Assert.AreEqual(10, result);
        }

         [Test]
        public void Calculation_Divide()
        {
            var objCalculation = new Calculation();

            var result = objCalculation.Divide(4,2);

            Assert.AreEqual(2, result);
        }
    }
}