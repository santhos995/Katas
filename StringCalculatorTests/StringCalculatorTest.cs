using Kata.StringCalculator;
using NUnit.Framework;
using System;

namespace StringCalculatorTests
{
    public class Tests
    {
        StringCalculator stringCalculator;
        [SetUp]
        public void Setup()
        {
            stringCalculator = new StringCalculator();
        }

        [Test]
        public void Add_EmptyString_Returns0()
        {
            int result = stringCalculator.Add(string.Empty);

            Assert.That(result == 0);
        }

        [Test]
        public void Add_SingleValue_ReturnsValue()
        {
            int result = stringCalculator.Add("5");

            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Add_TwoValues_ReturnsTheAddedValue()
        {
            int result = stringCalculator.Add("1,2");

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Add_TwoValuesWithNewLineDemiliter_ReturnsTheSum()
        {
            int result = stringCalculator.Add("1\n2");

            Assert.That(result, Is.EqualTo(3));
        }
        [Test]
        public void Add_MultipleValuesWithMultiDelimiters_ReturnsTheSum()
        {
            int result = stringCalculator.Add("1\n2,3");

            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Add_InvalidInput_ThrowsInvalidException()
        {
            Assert.Throws<ArgumentException>(() => stringCalculator.Add("1,\n"));
        }

        [Test]
        public void Add_PassCustomDelimiter_ReturnsTheSum()
        {
            int result = stringCalculator.Add("//;\n1;2");

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Add_PassNegativeNumber_ThrowsArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => stringCalculator.Add("1,-2"));
            Assert.That(ex.Message, Is.EqualTo("Negatives not allowed - -2,"));
        }

        [Test]
        public void Add_NumberWithValueMoreThan1000_ReturnsTheSumWithoutValueMoreThan1000()
        {
            int result = stringCalculator.Add("1,1001");

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Add_NumberWithMultipleLengthDelimiters_ReturnsTheSum()
        {
            int result = stringCalculator.Add("//[***]\n1***2");

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Add_NumbersWithMultipleMultiLengthDelimiters_ReturnsTheSum()
        {
            int result = stringCalculator.Add("//[***][;;]\n1;;2***3");

            Assert.That(result, Is.EqualTo(6));
        }
    }

}