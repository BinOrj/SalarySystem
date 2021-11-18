using SalarySystem.Data;
using SalarySystem.Models;
using SalarySystem.Utilities;
using System;

namespace SalarySystem.Controllers
{
    public class LoginController
    {
        public void LogIn()
        {
            EmployeeHelper helper = new();
            Console.WriteLine("Enter Username and Password to login\n");
            var credentials = InputHelper.AskForCredentials();

            var employee = helper.CheckIfEmployeExists(credentials[0], credentials[1], DataStructure.EmployeesList);
            if (employee != null)
            {
                
                helper.MenuDirection(employee);
            }
        }
    }
}