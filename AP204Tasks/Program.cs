using System;
using ClassLibrary;

namespace AP204Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employe = new Employee();
            employe.Name = "Murad";
            employe.Surname = "Aslanov";
            employe.Salary = 4000;

            Department department = new Department();
            department.Name = "FullStack Developer";
            department.SalaryLimit = 5000;
            department.AddEmploye(employe);

            foreach (var item in department.Employees)
            {
                Console.WriteLine($"Ishcinin Adi : {item.Name} Ishcinin Soyadi {item.Surname} Ishcinin Masshi {item.Salary}  " );
            }

        }
    }
}
