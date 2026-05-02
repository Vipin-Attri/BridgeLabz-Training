namespace AddTwoNumbers
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_TwoNumbers_ReturnsCorrectSum()
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            int result = calc.Add(2, 3);

            // Assert
            Assert.AreEqual(5, result);
        }
    }
}