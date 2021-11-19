using SalarySystem.Data;
using SalarySystem.Utilities;
using System;

namespace SalarySystem.Controllers
{
    public class LoginController
    {
        public void Start()
        {
            LogIn();
        }

        public void LogIn()
        {
            EmployeeHelper helper = new();

            var counter = 1;
            while (counter <= 3)
            {
                Console.WriteLine("Enter Username and Password to login\n");
                var credentials = InputHelper.AskForCredentials();
                var employee = helper.CheckIfEmployeExists(credentials[0], credentials[1], DataStructure.EmployeesList);
                if (employee != null)
                {
                    helper.MenuDirection(employee);                   
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Wrong crendentials, you got: {3 - counter} tries left");
                    counter++;
                }
            }

        }
    }
}