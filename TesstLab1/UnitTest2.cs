using Lab1CSha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesstLab1
{
    public class UnitTest2
    {
        [Fact]
        public void TestCompactMatrix()
        {
            // Arrange
            SecondPart secondPart = new SecondPart();
            int[,] matrix = {
                {1, 0, 3},
                {4, 0, 6},
                {0, 0, 0}
            };

            // Act
            int[,] result = secondPart.CompactMatrix(matrix);

            // Assert
            Assert.Equal(new int[,] { { 1, 3 }, { 4, 6 } }, result);
        }

        [Fact]
        public void TestFindFirstPositiveRow()
        {
            // Arrange
            SecondPart secondPart = new SecondPart();
            int[,] matrix = {
                {0, 0, 0 },
                {-1, -2, -3},
                {0, 0, 0},
                {4, 5, 6 }
            };

            // Act
            int result = secondPart.FindFirstPositiveRow(matrix);

            // Assert
            Assert.Equal(4, result);
        }
    }
}
