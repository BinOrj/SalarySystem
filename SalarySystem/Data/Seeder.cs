using SalarySystem.Models;

namespace SalarySystem.Data
{
    public class Seeder
    {
        public static void EmployeesSeeder()
        {
            DataStructure.EmployeesList.Add(new Employees("Dalmas", "123", "Emil", "Örjes", 30000, new Roles[] { Roles.Admin, Roles.Programmer }));
            DataStructure.EmployeesList.Add(new Employees("Hudik", "123", "Tobias", "Binett", 30000, new Roles[] { Roles.Programmer }));
            DataStructure.EmployeesList.Add(new Employees("Gezz", "123", "Amanda", "Gezelius", 45000, new Roles[] { Roles.CEO, Roles.HR }));
        }
    }
}