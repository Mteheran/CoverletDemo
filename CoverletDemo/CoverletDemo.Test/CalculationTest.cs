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
        public void Calculation_2_Items()
        {
            var arrayOfNumbers = new List<int>() { 1, 5, 4 };

            var objCal = new Calculation();

            var result = objCal.Plus(arrayOfNumbers);

            Assert.AreEqual(10, result);
        }
    }
}