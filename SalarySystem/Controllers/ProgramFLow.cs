﻿using SalarySystem.Data;
using SalarySystem.Models;
using System;

namespace SalarySystem.Controllers
{
    public class ProgramFLow
    {
        public void Start()
        {
            Seeder.EmployeesSeeder();
            LoginController logIn = new();
            while (true)
            {
                Console.Clear();
                logIn.LogIn();
            }
        }
    }
}