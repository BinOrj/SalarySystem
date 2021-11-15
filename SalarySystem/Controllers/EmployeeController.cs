using SalarySystem.Models;
using SalarySystem.Utilities;
using System;

namespace SalarySystem.Controllers
{
    public class EmployeeController
    {
        public void UserMenu(Employees employee)
        {
            EmployeeHelper helper = new();
            bool loop = true;

            while (loop)
            {
                Console.Clear();
                Console.WriteLine("1. Show info");
                Console.WriteLine("2. Delete this user");
                Console.WriteLine("3. Logout");
                Console.Write("Choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (choice)
                {
                    case 1:
                        helper.ShowInfoAboutThisEmployee(employee);
                        break;

                    case 2:
                        helper.DeleteMyAccount(employee);
                        break;

                    case 3:
                        Console.WriteLine("Logging out");
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}