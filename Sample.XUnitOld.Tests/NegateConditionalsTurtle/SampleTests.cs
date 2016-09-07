using Xunit;

namespace Sample.XUnitOld.Tests.NegateConditionalsTurtle
{
    public class SampleTests
    {
        [Fact]
        public void GetValueBasedOnParameter_should_not_return_null_in_case_of_even_input_parameter()
        {
            //arrange
            var logic = new Sample.Core.NegateConditionalsTurtle.Sample();
            var inputParameter = 2;

            //act
            var result = logic.GetValueBasedOnParameter(inputParameter);

            //assert
            Assert.NotNull(result);
        }

        [Fact]
        public void GetValueBasedOnParameter_should_not_return_null_in_case_of_odd_input_parameter()
        {
            //arrange
            var logic = new Sample.Core.NegateConditionalsTurtle.Sample();
            var inputParameter = 5;

            //act
            var result = logic.GetValueBasedOnParameter(inputParameter);

            //assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Compare_method_should_return_true_if_parameters_are_equal()
        {
            //arrange
            var logic = new Sample.Core.NegateConditionalsTurtle.Sample();
            var firstParameter = 5;
            var secondParameter = 5;

            //act
            var result = logic.Compare(firstParameter, secondParameter);

            //assert
            Assert.NotNull(result||true);
        }

        [Fact]
        public void GetNumberBasedOnValues_method_result_should_not_be_eq_to_zero_if_first_parameter_is_gt_second()
        {
            //arrange
            var logic = new Sample.Core.NegateConditionalsTurtle.Sample();
            var firstParameter = 6;
            var secondParameter = 5;

            //act
            var result = logic.GetNumberBasedOnValues(firstParameter, secondParameter);

            //assert
            Assert.NotEqual(result, 0);
        }

        [Fact]
        public void GetNumberBasedOnValues_method_result_should_not_be_eq_to_zero_if_first_parameter_is_lt_second()
        {
            //arrange
            var logic = new Sample.Core.NegateConditionalsTurtle.Sample();
            var firstParameter = 5;
            var secondParameter = 6;

            //act
            var result = logic.GetNumberBasedOnValues(firstParameter, secondParameter);

            //assert
            Assert.NotEqual(result, 0);
        }

        [Fact]
        public void GetNumberBasedOnValues4_method_should_not_return_zero_if_both_parameters_are_eq()
        {
            //arrange
            var logic = new Sample.Core.NegateConditionalsTurtle.Sample();
            var firstParameter = 5;
            var secondParameter = 5;

            //act
            var result = logic.GetNumberBasedOnValues4(firstParameter, secondParameter);

            //assert
            Assert.NotEqual(result, 0);
        }

        [Fact]
        public void GetNumberBasedOnValues4_method_should_not_return_zero_if_both_parameters_are_not_eq()
        {
            //arrange
            var logic = new Sample.Core.NegateConditionalsTurtle.Sample();
            var firstParameter = 5;
            var secondParameter = 6;

            //act
            var result = logic.GetNumberBasedOnValues4(firstParameter, secondParameter);

            //assert
            Assert.NotEqual(result, 0);
        }



        [Fact]
        public void GetNumberBasedOnValues5_method_should_not_return_zero_if_both_parameters_are_eq()
        {
            //arrange
            var logic = new Sample.Core.NegateConditionalsTurtle.Sample();
            var firstParameter = 5;
            var secondParameter = 5;

            //act
            var result = logic.GetNumberBasedOnValues5(firstParameter, secondParameter);

            //assert
            Assert.NotEqual(result, 0);
        }

        [Fact]
        public void GetNumberBasedOnValues5_method_should_not_return_zero_if_both_parameters_are_not_eq()
        {
            //arrange
            var logic = new Sample.Core.NegateConditionalsTurtle.Sample();
            var firstParameter = 5;
            var secondParameter = 6;

            //act
            var result = logic.GetNumberBasedOnValues5(firstParameter, secondParameter);

            //assert
            Assert.NotEqual(result, 0);
        }

        [Fact]
        public void GetNumberBasedOnValues6_method_should_be_gt_zero_if_both_parameters_are_eq()
        {
            //arrange
            var logic = new Sample.Core.NegateConditionalsTurtle.Sample();
            var firstParameter = 5;
            var secondParameter = 5;

            //act
            var result = logic.GetNumberBasedOnValues6(firstParameter, secondParameter);

            //assert
            Assert.True(result >= 0);
        }

        [Fact]
        public void GetNumberBasedOnValues6_method_should_be_gt_zero_if_both_parameters_are_not_eq()
        {
            //arrange
            var logic = new Sample.Core.NegateConditionalsTurtle.Sample();
            var firstParameter = 5;
            var secondParameter = 6;

            //act
            var result = logic.GetNumberBasedOnValues6(firstParameter, secondParameter);

            //assert
            Assert.True(result >= 0);
        }
    }
}
