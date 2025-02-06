internal class Program
{
    //delegate refers to a method
    //1. Signature of delegate should match with the method
    public delegate void delsample(string nm);
    private static void Main(string[] args)
    {
        //2. create instance for delegate - set the target method
        delsample del = new delsample(Display);
        //invoke the delegate
        del("Welcome to Delegates");//calling display method
    }
    static void Display(string msg)
    {
        Console.WriteLine(msg);
    }
}