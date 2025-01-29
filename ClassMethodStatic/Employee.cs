using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodStatic
{
    internal class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Dept { get; set; }
        public decimal Salary { get; set; }

        //Constructor
        public Employee(int id, string name, string dept, decimal sal)
        {
            EmpId = id;
            EmpName = name;
            Dept = dept;
            Salary = sal;
        }
        //Methods
        public void Display()
        {
            Console.WriteLine("EmployeeDetails:");
            Console.WriteLine($"EmployeeID: {EmpId} ; EmployeeName: {EmpName} ; Department: {Dept} ; Salary: {Salary}");
        }
    }
}
