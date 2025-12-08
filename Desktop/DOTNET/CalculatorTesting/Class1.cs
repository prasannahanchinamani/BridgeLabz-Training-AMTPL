using Calculator;
using NUnit.Framework;

namespace CalculatorTesting
{
    [TestFixture]
    public class Class1
    {
        private ArthmaticExp exp;

        [SetUp]
        public void ObjReference()
        {

            exp = new ArthmaticExp();
        }

        [Test]
        public void AddTest()
        {
            Assert.That(exp.Add(20, 20), Is.EqualTo(40));
        }

        [Test]
        public void SubstractTest()
        {
            Assert.That(exp.Subtract(20,10),Is.EqualTo(10));
        }
        [Test]
        public void MultiplyTest()
        {
            Assert.That(exp.Multiply(10,10), Is.EqualTo(100));
        }
        [Test]
        public void DivideTest() {
            Assert.That(exp.Divide(10,10), Is.EqualTo(1));
        }

    }
}