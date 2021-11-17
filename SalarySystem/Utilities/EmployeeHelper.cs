using SalarySystem.Controllers;
using SalarySystem.Data;
using SalarySystem.Models;
using System;
using System.Collections.Generic;

namespace SalarySystem.Utilities
{
    public class EmployeeHelper
    {
        public void AddNewEmployee(List<Employees> list)
        {
            var username = EnterUsername();
            var password = EnterPassword();
            var firstname = EnterFirstName();
            var surname = EnterSurname();
            var salary = EnterSalary();

            string roles = Roles.Programmer.ToString();
            bool isAdmin = false;

            Employees employee = new(username, password, firstname, surname, salary, roles, isAdmin);
            list.Add(employee);
        }

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

            DeleteInfo(employee);
            var username = EnterUsername();
            var password = EnterPassword();

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

        public void DeleteInfo(Employees employee)
        {
            Console.WriteLine($"\nUsername: {employee.UserName}   Password: {employee.Password}");
            Console.WriteLine("Enter username and password to delete this user");
        }

        public bool DeleteMyAccount(Employees employee)
        {
            DeleteInfo(employee);
            var username = EnterUsername();
            var password = EnterPassword();

            if (username == employee.UserName && password == employee.Password)
            {
                Console.WriteLine($"{employee.UserName} is deleted!");
                DataStructure.EmployeesList.Remove(employee);
                return true;
            }
            else
            {
                Console.WriteLine("Wrong Username or Password!");
                return false;
            }
        }

        public string EnterPassword()
        {
            Console.Write("Enter Password: ");
            return Console.ReadLine();
        }

        public string EnterUsername()
        {
            Console.Write("Enter username: ");
            return Console.ReadLine();
        }

        public string EnterFirstName()
        {
            Console.Write("Enter firstname: ");
            return Console.ReadLine();
        }

        public string EnterSurname()
        {
            Console.Write("Enter surname: ");
            return Console.ReadLine();
        }

        public decimal EnterSalary()
        {
            Console.Write("Enter salary: ");
            return Convert.ToDecimal(Console.ReadLine());
        }
        public bool IsEmployeAdmin(Employees employe)
        {
            return employe.IsAdmin;
        }

        public void ListOfRoles()
        {
            int counter = 1;
            foreach (var role in Enum.GetNames(typeof(Roles)))
            {
                Console.WriteLine($"{counter}. {role}");
                counter++;
            }
        }

        public void MenuDirection(bool isAdmin, Employees employee)
        {
            EmployeeController userController = new();
            AdminController adminController = new();

            if (isAdmin) adminController.AdminMenu(employee);
            else userController.EmployeeMenu(employee);
        }

        public void ShowInfoAboutThisEmployee(Employees employee)
        {
            Console.WriteLine($"Name: {employee.Firstname} {employee.Surname}");
            Console.WriteLine($"Role: {employee.Role}");
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
    }
}