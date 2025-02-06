using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyDelegates
{
    public delegate bool IsPromotable(Employee emp);
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int experienceinyears { get; set; }
        public decimal salary { get; set; }

        public static void PromoteEmployee(List<Employee> empList, IsPromotable isEligible)
        {
            foreach (Employee emp in empList)
            {
                if (isEligible(emp))
                {
                    Console.WriteLine($"Employee {emp.EmpName} is promoted");
                }
            }
        }


        
    }
}
