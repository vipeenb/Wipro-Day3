using WhyDelegates;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee(){EmpId = 1,EmpName="Vipeen",experienceinyears=3,salary=60000 },
            new Employee(){EmpId = 1,EmpName="Ankit",experienceinyears=5,salary=70000 },
            new Employee(){EmpId = 1,EmpName="Varun",experienceinyears=4,salary=80000 },
            new Employee(){EmpId = 1,EmpName="Pritish",experienceinyears=2,salary=90000 },
            new Employee(){EmpId = 1,EmpName="Rthwik",experienceinyears=6,salary=50000 },
            new Employee(){EmpId = 1,EmpName="Aditya",experienceinyears=8,salary=95000 }
        };
        IsPromotable delpromote = new IsPromotable(IsPromote);//created instance for delegate ,set the target method

        Employee.PromoteEmployee(employees, delpromote);//calling the method Promote Employee
    }

    static bool IsPromote(Employee emp)
    {
        if (emp.salary > 70000)
        {
            return true;
        }
        return false;
    }
}
