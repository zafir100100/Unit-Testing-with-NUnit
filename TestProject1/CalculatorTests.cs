using ConsoleApp1;

namespace TestProject1
{
    public class Tests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            var result = _calculator.Add(3, 2);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Subtract_TwoNumbers_ReturnsCorrectDifference()
        {
            var result = _calculator.Sub(5, 3);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Multiply_TwoNumbers_ReturnsCorrectProduct()
        {
            var result = _calculator.Mul(3, 4);
            Assert.That(result, Is.EqualTo(12));
        }

        [Test]
        public void Divide_TwoNumbers_ReturnsCorrectQuotient()
        {
            var result = _calculator.Div(10, 2);
            Assert.That(result, Is.EqualTo(5.0));
        }

        [Test]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Div(10, 0));
        }
    }
}