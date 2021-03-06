﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Demo08Laskukone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08Laskukone.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //Arrange
            Calculator calc = new Calculator();
            int number1 = 5;
            int number2 = 7;
            int expected = 12;

            //Act
            int actual = calc.Add(number1, number2);

            //assert
            Assert.AreEqual(expected, actual);

          
        }

        [TestMethod()]
        public void MultipleTest()
        {  
            //Arrange
            Calculator calc = new Calculator();
            int number1 = 5;
            int number2 = 7;
            int expected = 35;

            //act
            int actual = calc.Multiple(number1, number2);

            //assert
            Assert.AreEqual(expected, actual);

           
        }
    }
}