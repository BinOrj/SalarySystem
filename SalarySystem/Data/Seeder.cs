using SalarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SalarySystem.Data
{
    public class Seeder
    {
        public static void EmployeesSeeder()
        {
            

           Employees.EmployeesList.Add(new Employees("Dalmas", "123", "Emil", "Örjes", 30000, new Roles[] { Roles.Admin, Roles.Programmer }));
           Employees.EmployeesList.Add(new Employees("Hudik", "321", "Tobias", "Binett", 30000, new Roles[] { Roles.Programmer }));
        }
    }
}
