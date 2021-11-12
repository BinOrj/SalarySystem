using SalarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarySystem.Controllers
{
    public class LoginController
    {
        public void LogIn()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            var employe = CheckIfEmployeExists(username, password, Employees.EmployeesList);
            var isAdmin = IsEmployeAdmin(employe);
            MenuDirection(isAdmin);
        }

        public Employees CheckIfEmployeExists(string username, string password, List<Employees> list)
        {
            foreach (Employees employe in list)
            {
                if (username == employe.UserName && password == employe.Password) return employe;
            }
            return null;
        }

        public bool IsEmployeAdmin(Employees employe)
        {
            return employe.Role.Contains(Roles.Admin);
        }

        public void MenuDirection(bool isAdmin)
        {
            if (isAdmin) AdminController.AdminMenu();
            else UserController.UserMenu();
        }
    }
}
