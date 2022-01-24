using NUnit.Framework;

namespace KarateChopTests
{
    public class Tests
    {
        Kata.KarateChop.KarateChop _karateChop;
        [SetUp]
        public void Setup()
        {
            _karateChop = new Kata.KarateChop.KarateChop();
        }

        [Test]
        [TestCase(-1, 3, new int[] { })]
        [TestCase(-1, 3, new int[] { 1 })]
        [TestCase(0, 1, new int[] { 1 })]

        [TestCase(0, 1, new int[] { 1, 3, 5 })]
        [TestCase(1, 3, new int[] { 1, 3, 5 })]
        [TestCase(2, 5, new int[] { 1, 3, 5 })]
        [TestCase(-1, 0, new int[] { 1, 3, 5 })]
        [TestCase(-1, 2, new int[] { 1, 3, 5 })]
        [TestCase(-1, 4, new int[] { 1, 3, 5 })]
        [TestCase(-1, 6, new int[] { 1, 3, 5 })]

        [TestCase(0, 1, new int[] { 1, 3, 5, 7 })]
        [TestCase(1, 3, new int[] { 1, 3, 5, 7 })]
        [TestCase(2, 5, new int[] { 1, 3, 5, 7 })]
        [TestCase(3, 7, new int[] { 1, 3, 5, 7 })]
        [TestCase(-1, 0, new int[] { 1, 3, 5, 7 })]
        [TestCase(-1, 2, new int[] { 1, 3, 5, 7 })]
        [TestCase(-1, 4, new int[] { 1, 3, 5, 7 })]
        [TestCase(-1, 6, new int[] { 1, 3, 5, 7 })]
        [TestCase(-1, 8, new int[] { 1, 3, 5, 7 })]
        public void Chop_WhenPassed_ReturnsValue(int result, int value, int[] arr)
        {
            int res = _karateChop.Chop(arr, value);


            Assert.That(res == result);
        }

        [Test]
        [TestCase(-1, 3, new int[] { })]
        [TestCase(-1, 3, new int[] { 1 })]
        [TestCase(0, 1, new int[] { 1 })]

        [TestCase(0, 1, new int[] { 1, 3, 5 })]
        [TestCase(1, 3, new int[] { 1, 3, 5 })]
        [TestCase(2, 5, new int[] { 1, 3, 5 })]
        [TestCase(-1, 0, new int[] { 1, 3, 5 })]
        [TestCase(-1, 2, new int[] { 1, 3, 5 })]
        [TestCase(-1, 4, new int[] { 1, 3, 5 })]
        [TestCase(-1, 6, new int[] { 1, 3, 5 })]

        [TestCase(0, 1, new int[] { 1, 3, 5, 7 })]
        [TestCase(1, 3, new int[] { 1, 3, 5, 7 })]
        [TestCase(2, 5, new int[] { 1, 3, 5, 7 })]
        [TestCase(3, 7, new int[] { 1, 3, 5, 7 })]
        [TestCase(-1, 0, new int[] { 1, 3, 5, 7 })]
        [TestCase(-1, 2, new int[] { 1, 3, 5, 7 })]
        [TestCase(-1, 4, new int[] { 1, 3, 5, 7 })]
        [TestCase(-1, 6, new int[] { 1, 3, 5, 7 })]
        [TestCase(-1, 8, new int[] { 1, 3, 5, 7 })]
        public void ChopRecursive_WhenPassed_ReturnsValue(int result, int value, int[] arr)
        {
            int res = _karateChop.ChopRecursive(arr, value);


            Assert.That(res == result);
        }
    }
}