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
            Assert.That(_uut.Add(12, 50), Is.EqualTo(62));
        }

        [Test]
        public void Add_TwoNumbers_OnePositive_OneNegative_Correctly()
        {
            Assert.That(_uut.Add(10, -5), Is.EqualTo(5));
        }

        [Test]
        public void Add_TwoNegativeNumbers_Correctly()
        {
            Assert.That(_uut.Add(-7, -10), Is.EqualTo(-17));
        }

        [Test]
        public void Subtract_TwoNumbers_Correctly()
        {
            Assert.That(_uut.Subtract(30,10), Is.EqualTo(20));
        }

        [Test]
        public void Subtract_TwoNegativeNumbers_Correctly()
        {
            Assert.That(_uut.Subtract(-30, -10), Is.EqualTo(-20));
        }

        [Test]
        public void Subtract_TwoNumbers_OnePositive_OneNegative_Correctly()
        {
            Assert.That(_uut.Subtract(-30, 10), Is.EqualTo(-40));
        }

        [Test]
        public void Multiply_TwoNumbers_Correctly()
        {
            Assert.That(_uut.Multiply(2, 10), Is.EqualTo(20));
        }

        [Test]
        public void Multiply_TwoNegativeNumbers_Correctly()
        {
            Assert.That(_uut.Multiply(-2, -10), Is.EqualTo(20));
        }

        [Test]
        public void Multiply_TwoNumbers_OnePositive_OneNegative_Correctlyy()
        {
            Assert.That(_uut.Multiply(-2, 10), Is.EqualTo(-20));
        }

        [Test]
        public void Power_Correctly()
        {
            Assert.That(_uut.Power(5, 2), Is.EqualTo(25));
        }

        [Test]
        public void Power_NegativeExponent_Correctly()
        {
            Assert.That(_uut.Power(5, -2), Is.EqualTo(0.04));
        }

        [Test]
        public void Power_NegativeNumber_RaisedByPositivePower_Correctly()
        {
            Assert.That(_uut.Power(-5, 2), Is.EqualTo(25));
        }

        [Test]
        public void Divide_TwoPositiveNumbers_Correctly()
        {
            Assert.That(_uut.Divide(4, 2), Is.EqualTo(2));
        }
        [Test]
        public void Divide_TwoNumbers_OnePositive_OneNegative_Correctly()
        {
            Assert.That(_uut.Divide(-50, 4), Is.EqualTo(-12.5));
        }
        [Test]
        public void Divide_TwoNegativeNumbers_Correctly()
        {
            Assert.That(_uut.Divide(-4, -2), Is.EqualTo(2));
        }

        [Test]
        public void AccumulatorCheck_after_AddingTwoNumbers()
        {
           _uut.Add(10,40);
           Assert.That(_uut.Accumulator, Is.EqualTo(50));
        }

        [Test]
        public void AccumulatorCheck_after_AddingTwoNegativeNumbers()
        {
            _uut.Add(-10, -40);
            Assert.That(_uut.Accumulator, Is.EqualTo(-50));
        }
        [Test]
        public void AccumulatorCheck_after_PowerTwoNumbers()
        {
            _uut.Power(10, 4);
            Assert.That(_uut.Accumulator, Is.EqualTo(10000));
        }
        [Test]
        public void ClearCheck_after_MultiplyingTwoPositiveNumbers()
        {
            _uut.Multiply(2, 10);
            Assert.That(_uut.Accumulator, Is.EqualTo(20));
            _uut.Clear();
            Assert.That(_uut.Accumulator, Is.EqualTo(0));
        }
        [Test]
        public void ClearCheck_after_AddingTwoNegativeNumbers()
        {
            _uut.Add(-12, -15);
            Assert.That(_uut.Accumulator, Is.EqualTo(-27));
            _uut.Clear();
            Assert.That(_uut.Accumulator, Is.EqualTo(0));
        }
        [Test]
        public void ClearCheck_after_SubstractTwoPositiveNumbers()
        {
            _uut.Subtract(2, 10);
            Assert.That(_uut.Accumulator, Is.EqualTo(-8));
            _uut.Clear();
            Assert.That(_uut.Accumulator, Is.EqualTo(0));
        }
        [Test]
        public void AddOverload_addTwoNumber_ThenAddOneNumber_Correctly()
        {
            Assert.That(_uut.Add(12, 50), Is.EqualTo(62));
            Assert.That(_uut.Add(8),Is.EqualTo(70));
        }
        [Test]
        public void AddOverload_addTwoNumber_ThenClear_ThenAddOneNumber_Correctly()
        {
            Assert.That(_uut.Add(12, 50), Is.EqualTo(62));
            _uut.Clear();
            Assert.That(_uut.Add(8), Is.EqualTo(8));
        }
        [Test]
        public void AddOverload_addTwoNumber_ThenAddOneNegativeNumber_Correctly()
        {
            Assert.That(_uut.Add(15, 30), Is.EqualTo(45));
            Assert.That(_uut.Add(5), Is.EqualTo(50));
        }

        [Test]
        public void SubstractOverload_SubstractTwoNumbers_ThenSubstractOneNumber_Correctly()
        {
            Assert.That(_uut.Subtract(50,5),Is.EqualTo(45));
            Assert.That(_uut.Subtract(10),Is.EqualTo(35));
        }
        [Test]
        public void SubstractOverload_SubstractTwoNumbers_ThenClear_ThenSubstractOneNumber_Correctly()
        {
            Assert.That(_uut.Subtract(50, 5), Is.EqualTo(45));
            _uut.Clear();
            Assert.That(_uut.Subtract(10), Is.EqualTo(-10));
        }
        [Test]
        public void SubstractOverload_SubstractTwoNumbers_ThenSubstractOneNegativeNumber_Correctly()
        {
            Assert.That(_uut.Subtract(50, 5), Is.EqualTo(45));
            Assert.That(_uut.Subtract(-10), Is.EqualTo(55));
        }

        [Test]
        public void testPowerOverload()
        {
            Assert.That(_uut.Power(5,2),Is.EqualTo(25));
            Assert.That(_uut.Accumulator, Is.EqualTo(25));
            Assert.That(_uut.Power(2),Is.EqualTo(625));
        }
    }
}