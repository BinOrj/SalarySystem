using SalarySystem.Controllers;
using SalarySystem.Data;
using System;

namespace SalarySystem
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Seeder.EmployeesSeeder();
            var loginController = new LoginController(); 
            loginController.Start();
        }
    }
}
