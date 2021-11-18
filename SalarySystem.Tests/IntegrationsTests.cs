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
        private Employees _admin;
        private Employees _user;

        [SetUp]
        public void Setup()
        {

            _empHelper = new();
            _empList = new();
            _admin = new Employees("Admin", "123", "Emil", "Örjes", 30000, Roles.Programmer.ToString(), true);
            _user = new Employees("User", "123", "Emil", "Örjes", 30000, Roles.Programmer.ToString(), false);
            _empList.Add(_admin);
            _empList.Add(_user);
        }

        [Test]
        public void Intergration_LogIn_Admin()
        {
            Assert.AreEqual(2, _empList.Count);
            Assert.AreEqual(_empHelper.CheckIfEmployeExists("Admin", "123", _empList), _admin);
            Assert.IsTrue(_empHelper.DeleteAccount("User", "123", _user, _empList));
            Assert.IsFalse(_empHelper.DeleteAccount("User", "123", _admin, _empList));
            Assert.AreEqual(1, _empList.Count);
        }

        [Test]
        public void Intergration_LogIn_User()
        {
            Assert.AreEqual(2, _empList.Count);
            Assert.AreEqual(_empHelper.CheckIfEmployeExists("User", "123", _empList), _user);
            Assert.IsFalse(_empHelper.DeleteAccount("User", "133", _user, _empList));
            Assert.IsTrue(_empHelper.DeleteAccount("User", "123", _user, _empList));
            Assert.AreEqual(1, _empList.Count);
        }
    }
}
