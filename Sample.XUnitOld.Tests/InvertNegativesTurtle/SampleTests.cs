using Xunit;

namespace Sample.XUnitOld.Tests.InvertNegativesTurtle
{
    public class SampleTests
    {
        [Fact]
        public void GetHardcodedNegative_method_should_not_return_zero()
        {
            //arrange
            var logic = new Sample.Core.InvertNegativesTurtle.Sample();

            //act
            var result = logic.GetHardcodedNegative();

            //assert
            Assert.NotEqual(result, 0);
        }

        [Fact]
        public void GetHardcodedNegative_method_should_not_return_minus_200()
        {
            //arrange
            var logic = new Sample.Core.InvertNegativesTurtle.Sample();

            //act
            var result = logic.GetHardcodedNegative();

            //assert
            Assert.NotEqual(result, -200);
        }

        [Fact]
        public void GetNegativeParameter_method_should_negate_positive_input_parameter()
        {
            //arrange
            var logic = new Sample.Core.InvertNegativesTurtle.Sample();
            var inputParameter = 42;

            //act
            var result = logic.GetNegativeParameter(inputParameter);

            //assert
            Assert.Equal(result, -42);
        }

        [Fact]
        public void GetRandomNegative_method_should_not_return_zero()
        {
            //arrange
            var logic = new Sample.Core.InvertNegativesTurtle.Sample();

            //act
            var result = logic.GetRandomNegative();

            //assert
            Assert.NotEqual(result, 0);
        }

        [Fact]
        public void GetNegativeByCondition_method_should_return_minus_2_in_case_of_true_input_parameter()
        {
            //arrange
            var logic = new Sample.Core.InvertNegativesTurtle.Sample();

            //act
            var result = logic.GetNegativeByCondition(true);

            //assert
            Assert.Equal(result, -2);
        }

        [Fact]
        public void GetNegativeByCondition_method_should_not_return_minus_2_in_case_of_false_input_parameter()
        {
            //arrange
            var logic = new Sample.Core.InvertNegativesTurtle.Sample();

            //act
            var result = logic.GetNegativeByCondition(false);

            //assert
            Assert.NotEqual(result, -2);
        }
    }
}
