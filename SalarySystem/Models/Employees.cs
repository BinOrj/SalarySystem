using SalarySystem.Interfaces;

namespace SalarySystem.Models
{
    public class Employees : IAccount
    {
        public Employees()
        {
        }

        public Employees(string userName, string password, string firstname, string surname, decimal salary, Roles[] role)
        {
            UserName = userName;
            Password = password;
            Firstname = firstname;
            Surname = surname;
            Salary = salary;
            Role = role;
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        public Roles[] Role { get; set; }
    }
}