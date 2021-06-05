using NUnit.Framework;
using ConsoleApp4;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(1,5,6)]
        [TestCase(4, 9,13)]
        [TestCase(8, 1,9)]
        public void getAddition_ProperlyValueForAddition_AddingPositiveNummbers(int x, int y, int expectedResult)
        {
            int result = operacjenaliczbach.GetAddition(x, y);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(19,1)]
        [TestCase(1, -12)]
        [TestCase(19, -1)]
        [TestCase(-2, -1)]
        public void getAddition_ReturnZeroAndText_AddingInProperlyValue(int x , int y)
        {
            int result = operacjenaliczbach.GetAddition(x, y);
            Assert.AreEqual(0, result);
        }
    }
}
