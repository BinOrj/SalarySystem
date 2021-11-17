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
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            var employee = helper.CheckIfEmployeExists(username, password, DataStructure.EmployeesList);
            var isAdmin = helper.IsEmployeAdmin(employee);
            helper.MenuDirection(isAdmin, employee);
        }
    }
}