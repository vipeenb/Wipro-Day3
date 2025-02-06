internal class Program
{
    //static class supports method overloading and method overriding
    static class MathCalc //efficient for utility functions - static members & static functions
    {
        public static int count = 0;//static
        public static double square(double num)
        {
            return num * num;
        }
        public static double square(int num)
        {
            return num * num;
        }
        public static double Cube(double num)
        {
            return num * num * num;
        }
        public static void Dsiplay()
        {
            count++;
            Console.WriteLine(count);
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine(MathCalc.square(50.2));
        MathCalc.Dsiplay();
    }
}