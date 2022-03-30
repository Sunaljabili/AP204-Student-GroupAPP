using System;
namespace ClassLibrary
{
    public class Department
    {
        public string Name { get; set; }

        public int EmployeeLimit { get; set; }

        public double SalaryLimit { get; set; }

        public Employee[] Employees = new Employee[0];

        public void AddEmploye(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employee;
        }
    }
}
