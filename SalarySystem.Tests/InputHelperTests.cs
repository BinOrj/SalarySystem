using NUnit.Framework;
using SalarySystem.Models;
using SalarySystem.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarySystem.Tests
{    
    public class InputHelperTests
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
        public void InputHelper_InstanciateNewEmployee_ReturnTrue()
        {
            
        }
    }
}
