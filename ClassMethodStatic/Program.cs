using ClassMethodStatic;

internal class Program
{
    static void Display(ref int n)//Method definition
    {
        n *= 20;
        Console.WriteLine("Static method");
    }

    static void OutSample(out int n)//Method definition
    {
        int a = 20;
        n = a*20;
        Console.WriteLine("Value of a inside OutSample "+a);
    }

    static int Division(int a, int b, out int r)//Method definition
    {
        r=a % b;//remainder as out parameter
        return a / b;
    }
    void Show()//Instance method
    {
        Console.WriteLine("Instance method");
    }
    //Method with return type
    int Add(int a, int b)
    {
        return a + b;
    }
    //Main method
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Program pgm = new Program();
        //pgm.Show();
        //int a = 20;
        //Console.WriteLine("Before calling the method: " + a);
        //Display(ref a);//Method calling
        //Console.WriteLine("After calling the method: " + a);
        //Console.WriteLine(pgm.Add(10, 20));

        ////Out parameter
        //OutSample(out a);
        //Console.WriteLine("value of a after OutSample: " + a);

        //int res;
        //Console.WriteLine(Division(100, 3, out res));
        //Console.WriteLine("Remainder: " + res);

        

        Employee[] emp = new Employee[1];
        //for (int i = 0; i < emp.Length; i++)
        //{
        //    Console.WriteLine("Enter EmployeeID: ");
        //    int id = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Employee Name: ");
        //    string name = Console.ReadLine();
        //    Console.WriteLine("Enter Department: ");
        //    string dept = Console.ReadLine();
        //    Console.WriteLine("Enter Salary: ");
        //    decimal sal = Convert.ToDecimal(Console.ReadLine());
        //    emp[i] = new Employee(id, name, dept, sal);

        //    // Debugging output
        //    //Console.WriteLine($"Employee created: ID={id}, Name={name}, Department={dept}, Salary={sal}");
        //}
        //for (int i = 0; i < emp.Length; i++)
        //{
        //    //Console.WriteLine(emp[i].EmpId + " " + emp[i].EmpName);
        //    emp[i].Display();


        //}
        Console.WriteLine("Employee Management System:");
        Console.WriteLine("1. Add Employee \n2. List Employee \n3. Update Employee \n4. Delete Employee");
        Console.WriteLine("Enter your choice: ");
        string choice = Console.ReadLine();
        EmployeeCRUDop empCRUD = new EmployeeCRUDop();

        switch(choice)
        {
            case "1":
                Console.WriteLine("Enter EmployeeID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Department: ");
                string dept = Console.ReadLine();
                Console.WriteLine("Enter Salary: ");
                decimal sal = Convert.ToDecimal(Console.ReadLine());
                empCRUD.AddEmployee(id, name, dept, sal);
                break;
            case "2":
                empCRUD.ListEmployee();
                break;
            case "3":
                empCRUD.UpdateEmployee();
                break;
            case "4":
                empCRUD.DeleteEmployee();
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }

    }
}