using Moq;
using TestingDemo;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace TestProjectUnit
{
    public class Tests
    {
        public int i = 50, j = 10;
        public bool result;

        [SetUp]
        public void CheckNonNegative()
        {
            if (i > 0 && j > 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
        }
        [Test]
        public void TestAdd()
        {
            if (result)
            {
                MathOp mop = new MathOp();
                int res = mop.Add(i, j);
                Assert.That(res, Is.EqualTo(60));

            }
            else
            {
                Assert.Fail();
            }

        }

        [Test]
        [TestCase(100, 2, 50)]
        [TestCase(50, 2, 25)]
        public void TestDiv(int a, int b, int actual)
        {

            MathOp mth = new MathOp();
            int result = mth.Div(a, b);
            Assert.That(result, Is.EqualTo(actual));

        }
        [Test]
        [Ignore("Not yet Implemented")]
        public void TestSub()
        {

        }

        [Test]
        public void TestPro()
        {
            //Arrange
            MathOp mh = new MathOp();
            //Act
            int res = mh.Mul(i, j);
            //Assert
            Assert.That(res, Is.EqualTo(500));
        }
        [Test]
        public void MockTest()
        {
            Mock<MathOp> m = new Mock<MathOp>();
            m.Setup(x => x.CheckValues()).Returns(true);
            Assert.That(m.Object.CheckValues(), Is.True);
        }
    }
}
