using NUnit.Framework;
using SalarySystem.Models;
using SalarySystem.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace SalarySystem.Tests
{
    public class InputHelperTests
    {      
        private List<Employees> _empList;

        [SetUp]
        public void Setup()
        {           
            _empList = new();
        }

        [Test]
        public void InputHelper_AskForCredentials_ShouldReturnStringArray()
        {
            // assert
            var stringReader = new StringReader("Yes");
            Console.SetIn(stringReader);
            // Act
            string[] get = InputHelper.AskForCredentials();
            //Assert
            Assert.AreEqual(get.Length,2);
        }

        [Test]
        public void InputHelper_EnterSalary_ShouldPass()
        {
            // assert
            var stringReader = new StringReader("2");
            Console.SetIn(stringReader);
            // Act
            decimal actual = InputHelper.EnterSalary();
            //Assert
            Assert.IsTrue(2 == actual);
        }

        [Test]
        public void InputHelper_EnterSalary_ShouldFail()
        {
            // assert
            var stringReader = new StringReader("2");
            Console.SetIn(stringReader);
            // Act
            decimal actual = InputHelper.EnterSalary();
            //Assert
            Assert.That(actual.Equals(2m));
        }
    }
}
