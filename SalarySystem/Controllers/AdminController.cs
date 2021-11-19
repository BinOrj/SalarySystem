using SalarySystem.Data;
using SalarySystem.Models;
using SalarySystem.Utilities;
using System;

namespace SalarySystem.Controllers
{
    public class AdminController
    {
        public void AdminMenu(Employees employee)
        {
            EmployeeHelper helper = new();
            bool loop = true;
            while (loop)
            {
                MenuView();
                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine(employee.GetUserInfo());
                            break;

                        case 2:
                            helper.ShowListOfEmployees(DataStructure.EmployeesList);
                            break;

                        case 3:
                            helper.AddNewEmployee(DataStructure.EmployeesList);
                            break;

                        case 4:
                            helper.DeleteEmployeesAccount(DataStructure.EmployeesList);
                            break;

                        case 5:
                            Console.WriteLine("Logging out");
                            loop = false;
                            break;

                        default:
                            Console.WriteLine("The input needs to match one of the menu choices!");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                }
                Console.ReadKey();
            }
        }

        private static void MenuView()
        {
            Console.Clear();
            Console.WriteLine("1. Show info");
            Console.WriteLine("2. Show info about all employees");
            Console.WriteLine("3. Add employee");
            Console.WriteLine("4. Delete employee");
            Console.WriteLine("5. Logout");
            Console.Write("Choice: ");
        }
    }
}