using SalarySystem.Models;

namespace SalarySystem.Data
{
    public class Seeder
    {
        public static void EmployeesSeeder()
        {
            DataStructure.EmployeesList.Add(new Employees("admin", "admin", "Lord", "Something", 30000, nameof(Roles.Programmer), true));
            DataStructure.EmployeesList.Add(new Employees("user1", "123", "Berit", "Karlsson", 30000, nameof(Roles.Programmer), false));
            DataStructure.EmployeesList.Add(new Employees("user2", "123", "Rutger", "Jönåker", 25, nameof(Roles.Tester), false));
        }
    }
}