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
        public void Test2_Demo_Login()
        {

            LoginController logIn = new();
            List<Employees> employeesList = new();

            Employees test = new ("Test", "123", "Emil", "Örjes", 30000, new Roles[] { Roles.Admin, Roles.Programmer });
            employeesList.Add(test);

            var employe = logIn.CheckIfEmployeExists("Test", "123", employeesList);
            var isAdmin = logIn.IsEmployeAdmin(employe);

            Assert.AreEqual(employe, test);
            Assert.IsTrue(isAdmin);
        }
    }
}