using NUnit.Framework;

namespace Summator.UnitTest
{
    public class SummatorTest
    {


        [Test]
        public void Test_Summator_SumTwoPositiveNumber()
        {
            var nums = new int[] { 1, 2 };
            var actual = Summator.Sum(nums);
            var expected = 3;
            Assert.That(actual, Is.EqualTo(expected));


        }

        [Test]

        public void Test_Summator_SumTwoNegativeNumbers()
        {
            var nums = new int[] { -1, -99 };
            var actual = Summator.Sum(nums);
            var expected = -100;
            Assert.That(actual, Is.EqualTo(expected));


        }

        [Test]
        public void Test_Summator_SumNumber()
        {
            var nums = new int[] { 6 };
            var actual = Summator.Sum(nums);
            var expected = 6;
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]

        public void Test_Summator_BigNambers()
        {
            var nums = new int[] { 20000000, 40000000 };
            var actual = Summator.Sum(nums);
            var expected = 60000000;
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Average_ThreePossitiveNumbers()
        {
            var numbers = new int[] { 11, 11, 15 };
            double actual = Summator.Average(numbers);
            var expected = 12.333333333333334;
            Assert.That(actual, Is.EqualTo(expected)); 
        }



        [Test]
        public void Test_Average_FourPossitiveNumbers()
        {
            var numbers = new int[] { 11, 11, 11, 15 };
            double actual = Summator.Average(numbers);
            double expected = 12;
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Average_TwoNumbers()
        {
            var numbers = new int[] {11, 15};
            double actual = Summator.Average(numbers);
            double expected = 13;
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Average_FiveNumbers()
        {
            var numbers = new int[] { 11, 15, 14, 16, 22 };
            double actual = Summator.Average(numbers);
            double expected = 15.6;
            Assert.That(actual, Is.EqualTo(expected));
        }

    }

}




