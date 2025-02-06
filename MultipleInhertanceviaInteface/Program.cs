using MultipleInhertanceviaInteface;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the type of employee 1.Permanent 2.Temporary");
        string? type = Console.ReadLine();

        if (type.ToLower().Contains("per"))
        {
            //  Employee employee = new PermanentEmployee() { empid = 111, empname = "Riya", salary = 70000 };
            PermanentEmployee employee = new PermanentEmployee() { empid = 101, empname = "Vipeen", salary = 70000 };
            employee.BasicDetails();
            employee.SalaryDetails();
            employee.AttendMeetings();
            Employee emp = new PermanentEmployee() { empid = 102, empname = "Ankit", salary = 80000 };
            emp.BasicDetails();
            emp.SalaryDetails();

        }
        else if (type.ToLower().Contains("temp"))
        {
            Employee tmp = new TemporaryEmployee()
            {
                empid = 111,
                empname = "Varun",
                salaryperday = 7000
            };
            tmp.BasicDetails();
            tmp.SalaryDetails();
        }
    }
}