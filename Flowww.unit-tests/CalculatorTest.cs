namespace Flowww.unit_tests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(6, 2, 3)]
        [InlineData(15, 3, 5)]
        public void Should_DivideProperly_When_DenominatorIsDifferentFromZero(int numerator, int denominator, int expectedResult)
        {
            //Arrange/Act
            var result = Calculator.Divide(numerator, denominator);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Should_RiseDivideByZeroException_When_DenominatorIs0()
        {
            //Arrange/Act
            Action act = () => Calculator.Divide(6, 0);

            //Assert
            var result = Assert.Throws<DivideByZeroException>(act);
        }
    }
}