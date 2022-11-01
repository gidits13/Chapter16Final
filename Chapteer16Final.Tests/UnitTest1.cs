using Chapter16Final;

namespace Chapteer16Final.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Additional(3,1)==4);
            Assert.That(calc.Additional(100, 10) == 110);
        }

        [Test]
        public void AdditionalMustReturnInCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Additional(3, 2) != 4);
            Assert.That(calc.Additional(100, 10) != 109);
        }

        [Test]
         public void SubtractionMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Subtraction(3, 2) == 1);
            Assert.That(calc.Subtraction(100, 10) ==90);
        }
        [Test]
        public void SubtractionMustReturnInCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Subtraction(3, 2) != 2);
            Assert.That(calc.Subtraction(100, 10) != 91);
        }

        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Miltiplication(3, 2) == 6);
            Assert.That(calc.Miltiplication(100, 10) == 1000);
        }
        [Test]
        public void MultiplicationMustReturnInCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Miltiplication(3, 2) != 7);
            Assert.That(calc.Miltiplication(100, 10) != 10000);
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Division(3, 3) == 1);
            Assert.That(calc.Division(100, 10) == 10);
        }
        [Test]
        public void DivisionByZeroMustThrow()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Division(1, 0));
        }

        [Test]
        public void DivisionMustReturnInCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Division(3, 1) != 2);
        }
    }
}