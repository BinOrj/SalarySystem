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
            LoginController logIn = new();
            logIn.LogIn();
        }
    }
}
