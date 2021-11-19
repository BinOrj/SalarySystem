using SalarySystem.Interfaces;

namespace SalarySystem.Models
{
    public class Employees : IAccount
    {
        public Employees(string userName, string password, string firstname, string surname, decimal salary, string role, bool isAdmin)
        {
            UserName = userName;
            Password = password;
            Firstname = firstname;
            Surname = surname;
            Salary = salary;
            Role = role;
            IsAdmin = isAdmin;
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
        public string Role { get; set; }
        public bool IsAdmin { get; set; }
        
        public string GetUserInfo()
        {
            return $" Name: {Firstname} {Surname}   Salary: {Salary}   Role: {Role}";
        }

        public string GetUserInfoAdmin()
        {
            return $" Name: {Firstname} {Surname}   Username: {UserName}   Password: {Password}";
        }
    }
}