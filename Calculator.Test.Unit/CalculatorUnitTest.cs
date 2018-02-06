using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        private HandTestingCalculator.Calculator _uut;
        
        [SetUp]
        public void SetUp()
        {
            _uut = new HandTestingCalculator.Calculator();
        }

        [Test]
        public void Add_TwoNumbers_SumIsCorrect()
        {
            Assert.That(_uut.Add(2, 3), Is.EqualTo(5));
        }

        [Test]
        public void Subtract_TwoNumbers_SumIsCorrect()
        {
            Assert.That(_uut.Subtract(4,2), Is.EqualTo(2));
        }

        [Test]
        public void Multiply_TowNumbers_SumIsCorrect()
        {
            Assert.That(_uut.Multiply(2,3), Is.EqualTo(6));
        }

        [Test]
        public void Power_OnePowerAnotherNumber_SumIsCorrect()
        {
            Assert.That(_uut.Power(2,2), Is.EqualTo(4));
        }
        [Test]
        public void Divide_TowNumbers_SumIsCorrect()
        {
            Assert.That(_uut.Divide(8,4), Is.EqualTo(2));
        }
    }
}
