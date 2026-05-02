namespace CalculatorTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckAddition()
        {
            Calculator calc = new Calculator();
            int result = calc.addition(4, 2);
            Assert.AreEqual(6, result);
        }
        public void CheckSubtraction()
        {
            Calculator calc = new Calculator();
            int result = calc.subtraction(102, 2);
            Assert.AreEqual(100, result);
        }
        public void CheckMultiplication()
        {
            Calculator calc = new Calculator();
            int result = calc.multiplication(15, 15);
            Assert.AreEqual(225, result);
        }
        public void CheckDivision()
        {
            Calculator calc = new Calculator();
            int result = calc.division(24, 6);
            Assert.AreEqual(4, result);
        }
    }
}