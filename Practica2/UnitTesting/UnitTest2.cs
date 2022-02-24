using Calculators;
using Xunit;
using Moq;

namespace UnitTesting
{
    public class UnitTestMoq
    {
        [Fact]
        public void CalculateFibonacciSeries_ForIntegerNumber_ReturnsCorrectResult()
        {
            //Arrange
            int n = 3;
            int expectedResult = 2;

            Mock<ICalculator> mockICalculator = new Mock<ICalculator>(); //Hacemos mock de la interfaz que necesitamos para instanciar un objeto Series
            mockICalculator.Setup( s => s.Add(It.IsAny<int>(), It.IsAny<int>()) ).Returns( (int a, int b) => a + b ); //Mock del metodo Add(), donde le pasamos cualquier par de enteros y devuelve una expresion lambda que toma esos enteros y los suma

            Series series = new Series(mockICalculator.Object); //Instanciamos un objeto Series
            
            //Act
            int result = series.Fibonacci(n);

            //Assert
            Assert.Equal(expectedResult, result);

        }


        [Fact]
        public void CalculateFactorial_OfIntegerValue_ReturnsCorrectResult()
        {
            //Arrange
            int n = 5;
            int expectedResult = 120;

            Mock<ICalculator> mockICalculator = new Mock<ICalculator>(); //Hacemos mock de la interfaz que necesitamos para instanciar un objeto Series
            mockICalculator.Setup(s => s.Mul(It.IsAny<int>(), It.IsAny<int>())).Returns((int a, int b) => a * b); //Mock del metodo Mul(), donde le pasamos cualquier par de enteros y devuelve una expresion lambda que toma esos enteros y los multiplica

            Series series = new Series(mockICalculator.Object); //Instanciamos un objeto Series

            //Act
            int result = series.Factorial(n);

            //Assert
            Assert.Equal(expectedResult, result);

        }
    }
}
