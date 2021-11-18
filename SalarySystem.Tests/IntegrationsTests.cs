using NUnit.Framework;
using SalarySystem.Models;
using SalarySystem.Utilities;
using System.Collections.Generic;

namespace SalarySystem.Tests
{
    public class IntegrationsTests
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
            var actual = _empHelper.AddingNewEmployee("Apa", "123", "Donkey", "Kong", 25000, Roles.Tester.ToString(), false, _empList);
            Assert.IsTrue(actual);
        }

        [Test]
        public void Test5_Demo_Intergration_LogIn()
        {

            EmployeeHelper helper = new();
            List<Employees> employeesList = new();

            Employees testEmploye = new("Test", "123", "Emil", "Örjes", 30000, Roles.Programmer.ToString(), true);
            employeesList.Add(testEmploye);

            var existingEmploye = helper.CheckIfEmployeExists("Test", "123", employeesList);
            var isAdmin = helper.IsEmployeAdmin(existingEmploye);

            Assert.AreEqual(existingEmploye, testEmploye);
            Assert.IsTrue(isAdmin);
        }

    }
}
