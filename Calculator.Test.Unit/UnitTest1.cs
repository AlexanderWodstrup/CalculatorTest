using NUnit.Framework;


namespace Calculator.Test.Unit
{
    public class CalculatorTests
    {
        private Calculator _uut;
        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        [Test]
        public void Add_TwoNumbers_Correctly()
        {
            //Arrange
   
            //Act
            
            //Assert
            Assert.That(_uut.Add(12, 50), Is.EqualTo(62));
        }

        [Test]
        public void Subtract_TwoNumbers_Correctly()
        {
            Assert.That(_uut.Subtract(30,10), Is.EqualTo(20));
        }

        [Test]
        public void Multiply_TwoNumbers_Correctly()
        {
            Assert.That(_uut.Multiply(2, 10), Is.EqualTo(20));
        }
        [Test]
        public void PowerCorrectly()
        {
            Assert.That(_uut.Power(5, 2), Is.EqualTo(25));
        }

    }
}