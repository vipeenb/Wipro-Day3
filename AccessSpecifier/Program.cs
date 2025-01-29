using WiproDay3;

namespace AccessSpecifier
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Customer cst = new Customer();
            cst.custId = 101;
            cst.custName = "Vipeen";
            cst.Display();
        }
    }
}