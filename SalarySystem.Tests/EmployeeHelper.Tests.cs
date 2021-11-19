using NUnit.Framework;
using SalarySystem.Interfaces;
using SalarySystem.Models;
using SalarySystem.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarySystem.Tests
{
    class EmployeeHelperTest
    {
        private EmployeeHelper _empHelper;
        private List<Employees> _empList;

        [SetUp]
        public void Setup()
        {
            _empHelper = new();
            _empList = new();
        }

        [Test]
        public void AddingNewEmployee_InstanciateNewEmployee_ReturnTrue()
        {
            var init = _empList.Count;
            var actual = _empHelper.AddingNewEmployee("Apa", "123", "Donkey", "Kong", 25000, Roles.Tester.ToString(), false, _empList);
            var afterAdd = _empList.Count;
            Assert.AreEqual(init +1, afterAdd);
            Assert.IsTrue(actual);
        }


        [Test]
        public void CheckIfEmployeExists_CheckIfTheListContainsEmployee_ShoulReturnEmployee()
        {
            var expected = new Employees("Test", "123", "Emil", "Örjes", 30000, Roles.Programmer.ToString(), true);
            _empList.Add(expected);

            var actual = _empHelper.CheckIfEmployeExists("Test", "123", _empList);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IsEmployeeAdmin_ChecksIfWmployeeIsAdmin_ShouldReturnTrue()
        {
            var excpected = new Employees("Test", "123", "Emil", "Örjes", 30000, Roles.Programmer.ToString(), true);
            _empList.Add(excpected);


            var actual = excpected.IsAdmin;


            Assert.IsTrue(actual);
        }


        [Test]
        public void EmployeeHelper_DeleteAccount_ShouldReturnTrue()
        {
            // Arrange
            Employees testEmploye = new("Test", "123", "Emil", "Örjes", 30000, Roles.Programmer.ToString(), true);
            _empList.Add(testEmploye);
            // Act
            var actual = _empHelper.DeleteAccount("Test", "123", testEmploye, _empList);
            // Assert            
            Assert.IsTrue(actual);
        }


        [Test]
        public void EmployeeHelper_DeleteAccount_ShouldReturnFalse()
        {
            // Arrange
            Employees testEmploye = new("Test", "123", "Emil", "Örjes", 30000, Roles.Programmer.ToString(), true);
            _empList.Add(testEmploye);
            // Act
            var actual = _empHelper.DeleteAccount("Test", "", testEmploye, _empList);
            // Assert            
            Assert.IsFalse(actual);
        }
    }
}
