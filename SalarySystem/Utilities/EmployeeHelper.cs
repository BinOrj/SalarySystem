using SalarySystem.Controllers;
using SalarySystem.Data;
using SalarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalarySystem.Utilities
{
    public class EmployeeHelper
    {
        public Employees CheckIfEmployeExists(string username, string password, List<Employees> list)
        {
            foreach (Employees employe in list)
            {
                if (username == employe.UserName && password == employe.Password) return employe;
            }
            return null;
        }

        public void DeleteEmployeesAccount(List<Employees> list)
        {
            ShowListOfEmployees(list);
            Console.Write("Enter number of wich employee you want to delete: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            var employee = list[choice - 1];

            Console.WriteLine($"\nUsername: {employee.UserName}   Password: {employee.Password}");
            Console.WriteLine("Enter username and password to delete this user");
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (username == employee.UserName && password == employee.Password)
            {
                if (IsEmployeAdmin(employee))
                {
                    Console.WriteLine("Cant delete Admin!");
                }
                else
                {
                    Console.WriteLine($"{employee.UserName} is deleted!");
                    list.Remove(employee);
                }
            }
            else
            {
                Console.WriteLine("Wrong Username or Password");
            }
        }

        public void DeleteMyAccount(Employees employee)
        {
            Console.WriteLine("Enter username and password to delete this user");
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            if (username == employee.UserName && password == employee.Password)
            {
                DataStructure.EmployeesList.Remove(employee);
            }
            else
            {
                Console.WriteLine("Wrong Username or Password!");
            }
        }

        public string GetRoles(Employees employee)
        {
            StringBuilder roles = new();
            foreach (Roles role in employee.Role)
            {
                roles.Append(role).Append(' ');
            }
            return roles.ToString();
        }

        public bool IsEmployeAdmin(Employees employe)
        {
            return employe.Role.Contains(Roles.Admin);
        }

        public void MenuDirection(bool isAdmin, Employees employee)
        {
            EmployeeController userController = new();
            AdminController adminController = new();

            if (isAdmin) adminController.AdminMenu(employee);
            else userController.UserMenu(employee);
        }

        public void ShowInfoAboutThisEmployee(Employees employee)
        {
            Console.WriteLine($"Name: {employee.Firstname} {employee.Surname}");
            Console.WriteLine($"Role: {GetRoles(employee)}");
            Console.WriteLine($"Salary: {employee.Salary}");
        }
        public void ShowListOfEmployees(List<Employees> list)
        {
            int counter = 1;
            foreach (Employees employee in list)
            {
                Console.WriteLine($"{counter}. Name: {employee.Firstname} {employee.Surname}   Username: {employee.UserName}   Password: {employee.Password}");
                counter++;
            }
        }

        public void AddNewEmployee(List<Employees> list)
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            Console.Write("Enter firstname: ");
            string firstname = Console.ReadLine();
            Console.Write("Enter surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter salary: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter roles");
            Roles[] roles = { Roles.Programmer};

            Employees employee = new(username, password, firstname, surname, salary, roles);
            list.Add(employee);
        }
    }
}