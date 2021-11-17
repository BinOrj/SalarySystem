using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using SalarySystem.Controllers;
using SalarySystem.Models;
using SalarySystem.Utilities;
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
        public void Test2_Demo_DeleteAccount()
        {
            EmployeeHelper helper = new();
            List<Employees> employeesList = new();

            Employees testEmploye = new("Test", "123", "Emil", "Örjes", 30000, Roles.Programmer.ToString(), true);
            employeesList.Add(testEmploye);

            var actual = helper.DeleteAccount(testEmploye.UserName, testEmploye.Password, testEmploye, employeesList);
            Assert.IsTrue(actual);
        }

        [Test]
        public void Test3_Demo_CheckIfEmployeExists()
        {

            EmployeeHelper helper = new();
            List<Employees> employeesList = new();

            Employees testEmploye = new("Test", "123", "Emil", "Örjes", 30000, Roles.Programmer.ToString(), true);
            employeesList.Add(testEmploye);

            var existingEmploye = helper.CheckIfEmployeExists("Test", "123", employeesList);

            Assert.AreEqual(existingEmploye, testEmploye);
        }

        [Test]
        public void Test4_Demo_IsEmployeAdmin()
        {

            EmployeeHelper helper = new();
            List<Employees> employeesList = new();

            Employees testEmploye = new("Test", "123", "Emil", "Örjes", 30000, Roles.Programmer.ToString(), true);
            employeesList.Add(testEmploye);

            var isAdmin = helper.IsEmployeAdmin(testEmploye);

            Assert.IsTrue(isAdmin);
        }

        [Test]
        public void Test5_Demo_Intergration_LogIn()
        {

            EmployeeHelper helper = new();
            List<Employees> employeesList = new();

            Employees testEmploye = new ("Test", "123", "Emil", "Örjes", 30000, Roles.Programmer.ToString(), true);
            employeesList.Add(testEmploye);

            var existingEmploye = helper.CheckIfEmployeExists("Test", "123", employeesList);
            var isAdmin = helper.IsEmployeAdmin(existingEmploye);

            Assert.AreEqual(existingEmploye, testEmploye);
            Assert.IsTrue(isAdmin);
        }
    }
}