using SalarySystem.Models;
using System;
using System.Collections.Generic;

namespace SalarySystem.Utilities
{
    public static class InputHelper
    {

        public static void DeleteInfo(Employees employee)
        {
            Console.WriteLine($"\nUsername: {employee.UserName}   Password: {employee.Password}");
            Console.WriteLine("Enter username and password to delete this user");
        }       

        public static bool EnterIfAdminOrNot()
        {
            Console.Write("Enter [admin] if admin. Otherwise press enter: ");
            string input = Console.ReadLine();
            if (input == "admin")
            {
                return true;
            }
            return false;
        }
        
        public static Roles EnterRole()
        {
            ListOfRoles();
            Console.Write("Enter the number of the role: ");
            bool success = int.TryParse(Console.ReadLine(),out int choice);
            if (success && choice < 0 || choice > 4) return (Roles)choice - 1;
            return Roles.Programmer;
        }

        public static decimal EnterSalary()
        {
            Console.Write("Enter salary: ");
            var sucees = decimal.TryParse(Console.ReadLine(), out decimal salary);
            return sucees ? salary : EnterSalary();
        }      

        public static string PromptUserForInput(string description)
        {
            Console.Write($"Enter {description}: ");
            string input = Console.ReadLine();
            while (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                Console.Write($" *****- Empty input, try again -***** \nEnter {description}: ");
                input = Console.ReadLine();
            }
            return input;
        }

        public static void ListOfRoles()
        {
            int counter = 1;
            foreach (var role in Enum.GetNames(typeof(Roles)))
            {
                Console.WriteLine($"{counter}. {role}");
                counter++;
            }
        }

        public static string[] AskForCredentials()
        {
            var creds = new string[2];
            for (int i = 0; i <= 1; i++)
            {
                Console.Write(i == 0 ? "Enter Username: " : "Enter Password: ");
                creds[i] = Console.ReadLine();
            }
            return creds;
        }

    }
}
