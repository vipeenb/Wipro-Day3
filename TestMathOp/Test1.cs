using TestingDemo;
namespace TestMathOp
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            MathOp obj = new MathOp();//arranging
            int res = obj.Add(10, 20);//act
            Assert.AreEqual(30, res);//assert passed if res==actualvalue
        }
        [TestMethod]
        public void TestMethodSub()
        {
            MathOp obj = new MathOp();
            int res = obj.Sub(20, 10);
            Assert.AreEqual(10, res);//assert passed if res==actualvalue
        }
        [TestMethod]
        public void TestMethodMul()
        {
            MathOp obj = new MathOp();
            int res = obj.Mul(10, 20);
            Assert.AreEqual(200, res);//assert passed if res==actualvalue
        }
    }
}
