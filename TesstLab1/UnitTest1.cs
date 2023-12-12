using Lab1CSha;

namespace TesstLab1
{
    public class UnitTest1
    {
        [Fact]
        public void TestFindMaxAbsIndex()
        {
            FirstPart firstPart = new FirstPart();
            double[] array = { -2.5, 3.2, -1.8, 5.6, -4.2 };
            int result = firstPart.FindMaxAbsIndex(array);
            Assert.Equal(3, result); // Replace with the expected result
        }

        [Fact]
        public void TestSumAfterFirstPositive()
        {
            FirstPart firstPart = new FirstPart();
            double[] array = { -2.5, 3.2, -1.8, 5.6, -4.2 };
            double result = firstPart.SumAfterFirstPositive(array);
            Assert.Equal(-0.4, result, precision: 5);
        }

        [Fact]
        public void TestTransformArray()
        {
            FirstPart firstPart = new FirstPart();
            double[] array = { -2.5, 3.2, -1.8, 5.6, -4.2 };
            double a = -3.0;
            double b = 3.0;
            firstPart.TransformArray(array, a, b);
            Assert.Equal(new double[] { -2.5, 3.2, -1.8, 5.6, -4.2 }, array);
        }
    }
}