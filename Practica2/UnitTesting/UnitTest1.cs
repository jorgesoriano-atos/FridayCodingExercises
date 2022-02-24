using Calculators;
using Xunit;

namespace UnitTesting
{
    public class UnitTestCalculator
    {
        [Fact]
        public void Add_TwoFloatNumbers_ReturnsCorrectResult()
        {
            //Arrange
            Calculator c = new Calculator();
            float n1 = 3;
            float n2 = 4;
            float expectedRes = 7;
            

            //Act
            float res = c.Add(n1, n2);

            //Assert
            Assert.Equal(expectedRes, res);
        }

        [Fact]
        public void Substract_TwoFloatNumbers_ReturnsCorrectResult()
        {
            //Arrange
            Calculator c = new Calculator();
            float n1 = 3;
            float n2 = 4;
            float expectedRes = -1;

            //Act
            float res = c.Sub(n1, n2);

            //Assert
            Assert.Equal(expectedRes, res);
        }

        [Fact]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            //Arrange
            Calculator c = new Calculator();
            float n1 = 3;
            float n2 = 0;

            Assert.Throws<System.DivideByZeroException>(() => {

                //Act
                float res = c.Div(n1, n2);

                //Assert
                Assert.IsType<float>(res);

            });


        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(20.3, -6.2, -125.85999)]
        [InlineData(220, 0, 0)]
        public void Multiply_TwoFloatNumbers_ReturnsCorrectResult(float n1, float n2, float expectedRes)
        {
            //Arrange
            Calculator c = new Calculator();
            float res = 0;

            //Act
            res = c.Mul(n1, n2);

            //Assert
            Assert.Equal(expectedRes, res);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(20, -8, -2.5)]
        [InlineData(220, 0.5, 440)]
        public void Divide_TwoFloatNumbers_ReturnsCorrectResult(float n1, float n2, float expectedRes)
        {
            //Arrange
            Calculator c = new Calculator();
            float res = 0;

            //Act
            res = c.Div(n1, n2);

            //Assert
            Assert.Equal(expectedRes, res);
        }
    }
}
