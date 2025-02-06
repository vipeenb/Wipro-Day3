using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInhertanceviaInteface
{
    internal interface Employee
    {
        void BasicDetails();
        void SalaryDetails();
    }
    //interface-segregation
    interface Meeting
    {
        void AttendMeetings();

    }
    class PermanentEmployee : Employee, Meeting//Multiple Inheritance
    {
        public int empid { get; set; }
        public string? empname { get; set; }
        public decimal salary { get; set; }

        public static string OrgName = "Wipro"; //shared among all instances of the class

        public void AttendMeetings()
        {
            Console.WriteLine("Attend Meetings");
        }

        public void BasicDetails()
        {
            Console.WriteLine(empid + " " + empname + " " + OrgName);
        }

        public void SalaryDetails()
        {
            Console.WriteLine(salary);
        }
    }
    class TemporaryEmployee : Employee
    {
        public int empid { get; set; }
        public string? empname { get; set; }
        public decimal salaryperday { get; set; }
        public void BasicDetails()
        {
            Console.WriteLine(empid + " " + empname);
        }

        public void SalaryDetails()
        {
            Console.WriteLine(salaryperday);
        }
    }
}
