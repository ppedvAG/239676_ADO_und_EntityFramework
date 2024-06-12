namespace Calculator.Tests
{
    public class CalcTests
    {
        [Fact]
        public void Sum_2_and_3_results_5()
        {
            //Arrange
            var calc = new Calc();

            //Act
            var result = calc.Sum(2, 3);

            //Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Sum_0_and_0_results_0()
        {
            //Arrange
            var calc = new Calc();

            //Act
            var result = calc.Sum(0, 0);

            //Assert
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 2, 3)]
        [InlineData(-5, -2, -7)]
        [InlineData(-5, 20, 15)]
        public void Sum_with_results(int a, int b, int exp)
        {
            //Arrange
            var calc = new Calc();

            //Act
            var result = calc.Sum(a, b);

            //Assert
            Assert.Equal(exp, result);
        }

        [Fact]
        public void Sum_MAX_and_1_throws_OverFlowException()
        {
            var calc = new Calc();

            Assert.Throws<OverflowException>(() => calc.Sum(int.MaxValue, 1));
        }
    }
}