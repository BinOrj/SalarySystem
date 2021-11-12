using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using SalarySystem.Controllers;
using SalarySystem.Models;
using System.Collections.Generic;

namespace SalarySystem.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1_Demo_ShouldPass()
        {
            Assert.Pass();
        }

        [Test]
        public void Test2_Demo_ShouldPass()
        {
            Assert.Pass();
        }

        [Test]
        public void Test3_Demo_CheckIfEmployeExists()
        {

            LoginController logIn = new();
            List<Employees> employeesList = new();

            Employees testEmploye = new("Test", "123", "Emil", "Örjes", 30000, new Roles[] { Roles.Admin, Roles.Programmer });
            employeesList.Add(testEmploye);

            var existingEmploye = logIn.CheckIfEmployeExists("Test", "123", employeesList);

            Assert.AreEqual(existingEmploye, testEmploye);
        }

        [Test]
        public void Test4_Demo_IsEmployeAdmin()
        {

            LoginController logIn = new();
            List<Employees> employeesList = new();

            Employees testEmploye = new("Test", "123", "Emil", "Örjes", 30000, new Roles[] { Roles.Admin, Roles.Programmer });
            employeesList.Add(testEmploye);

            var isAdmin = logIn.IsEmployeAdmin(testEmploye);

            Assert.IsTrue(isAdmin);
        }

        [Test]
        public void Test5_Demo_Intergration_LogIn()
        {

            LoginController logIn = new();
            List<Employees> employeesList = new();

            Employees testEmploye = new ("Test", "123", "Emil", "Örjes", 30000, new Roles[] { Roles.Admin, Roles.Programmer });
            employeesList.Add(testEmploye);

            var existingEmploye = logIn.CheckIfEmployeExists("Test", "123", employeesList);
            var isAdmin = logIn.IsEmployeAdmin(existingEmploye);

            Assert.AreEqual(existingEmploye, testEmploye);
            Assert.IsTrue(isAdmin);
        }
    }
}