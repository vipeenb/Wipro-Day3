using MulticaseDelegate;
internal class Program
{
    private static void Main(string[] args)
    {
        MathOperation mth = new MathOperation(MathOpe.Add);

        mth.Invoke(10,20);//add
        mth(20,30);//add

        mth += MathOpe.Multiply;
        mth += MathOpe.Divide;
        mth += MathOpe.Subtract;//method holds for add, multiply, divide and subtract

        mth(50,50);

        //System(predefined) or Anonymous delagate
        //1. Function delegate
        //2. Action delegate
        //3. Predicate delegate

        //Function delegate-0-16 input parameters and 1 output parameter
        Func<int, int, int , int> fundel = delegate (int a, int b, int c)
        {
            return a + b + c;
        };
        //call the anonymous delegate
        Console.WriteLine(fundel(10,20,30));
    }
}