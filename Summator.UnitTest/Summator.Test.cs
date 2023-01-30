using NUnit.Framework;

namespace Summator.UnitTest
{
    public class SummatorTest
    {


        [Test]
        public void Test_Summator_SumTwoPositiveNumber()
        {
            var nums = new int[] { 1, 2, };
            var actual=Summator.Sum(nums);
            var expected = 3;
            Assert.AreEqual(expected, actual);


        }

        [Test]

        public void Test_Summator_SumTwoNegativeNumbers()
        {
            var nums = new int[] { -1, -99};
            var actual = Summator.Sum(nums);
            var expected = -100;
            Assert.AreEqual(expected, actual);


        }

        [Test]
        public void Test_Summator_SumNumber()
        {
            var nums = new int[] { 6};
            var actual = Summator.Sum(nums);
            var expected=6;
            Assert.AreEqual(expected, actual);


        }
    }
}
