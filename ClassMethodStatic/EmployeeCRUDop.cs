using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodStatic
{
    internal class EmployeeCRUDop
    {
        private const int size = 5;
        //create array of 5 employees
        Employee[] emps = new Employee[size];
        private int Empcount = 0;

        //Method to create employee
        public void AddEmployee(int EmpId, string EmpName, string Dept, decimal Salary)
        {
            emps[Empcount] = new Employee(EmpId, EmpName, Dept, Salary);
            Empcount++;
            Console.WriteLine("Employee added successfully");
        }
        public void ListEmployee()
        {
            for (int i = 0; i < Empcount; i++)
            {
                emps[i].Display();
            }
        }
        public void UpdateEmployee()
        {

        }
        public void DeleteEmployee()
        {
        }
    }
}
