using SalarySystem.Controllers;
using SalarySystem.Models;
using System;
using System.Collections.Generic;
using static SalarySystem.Utilities.InputHelper;

namespace SalarySystem.Utilities
{
    public class EmployeeHelper
    {
        public bool AddingNewEmployee(string username, string password, string firstname, string surname, decimal salary, string role, bool isAdmin, List<Employees> list)
        {
            try
            {
                Employees employee = new(username, password, firstname, surname, salary, role, isAdmin);
                list.Add(employee);
                Console.WriteLine($"New employee with username {username} is added!");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong" + e.Message);
                return false;
            }
        }

        public void AddNewEmployee(List<Employees> list)
        {
            Console.WriteLine("Enter info to add a new employee\n");
            var username = EnterUsername("username");
            var password = EnterUsername("password");
            var firstname = EnterUsername("firstname");
            var surname = EnterUsername("surname");
            var salary = EnterSalary();
            var role = EnterRole().ToString();
            var isAdmin = EnterIfAdminOrNot();

            AddingNewEmployee(username, password, firstname, surname, salary, role, isAdmin, list);
        }


        public Employees CheckIfEmployeExists(string username, string password, List<Employees> list)
        {
            foreach (Employees employe in list)
            {
                if (username == employe.UserName && password == employe.Password) return employe;
            }
            return null;
        }

        public bool DeleteAccount(string username, string password, Employees employee, List<Employees> list)
        {
            if (username == employee.UserName && password == employee.Password)
            {
                Console.WriteLine($"{employee.UserName} is deleted!");
                list.Remove(employee);
                return true;
            }
            else
            {
                Console.WriteLine("Wrong Username or Password!");
                return false;
            }
        }

        public void DeleteEmployeesAccount(List<Employees> list)
        {
            ShowListOfEmployees(list);
            Console.Write("Enter number of wich employee you want to delete: ");
            var employee = EmployeeToDelete(list);

            DeleteInfo(employee);
            var credentials = AskForCredentials();

            if (credentials[0] == employee.UserName && credentials[1] == employee.Password)
            {
                if (employee.IsAdmin)
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

        public bool DeleteMyAccount(Employees employee, List<Employees> list)
        {
            DeleteInfo(employee);        
            var credentials = AskForCredentials();

            return DeleteAccount(credentials[0], credentials[1], employee, list);
        }      

        public void MenuDirection(Employees employee)
        {
            EmployeeController userController = new();
            AdminController adminController = new();

            if (employee.IsAdmin) adminController.AdminMenu(employee);
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
                Console.WriteLine($"{counter}" + employee.GetUserInfo());
                counter++;
            }
        }
    }
}