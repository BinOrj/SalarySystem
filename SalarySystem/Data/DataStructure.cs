using SalarySystem.Models;
using System.Collections.Generic;

namespace SalarySystem.Data
{
    public static class DataStructure
    {
        public static List<Employees> EmployeesList { get; set; } = new();

        public static void EmployeesSeeder()
        {
            EmployeesList.Add(new Employees("admin", "admin123", "Lord", "Something", 30000, nameof(Roles.Programmer), true));
            EmployeesList.Add(new Employees("user1", "123", "Berit", "Karlsson", 30000, nameof(Roles.Programmer), false));
            EmployeesList.Add(new Employees("user2", "123", "Rutger", "Jönåker", 25, nameof(Roles.Tester), false));
        }
    }
}