using System;
using Xunit;

namespace Sample.XUnit.Tests.MathTurtle
{
    public class SampleForDoubleTests
    {
        [Fact]
        public void Summ_method_result_should_be_positive_in_case_of_both_positive_input_parameters()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForDouble();
            var firstParameter = 10;
            var secondParameter = 5;

            //act
            var result = logic.Summ(firstParameter, secondParameter);

            //assert
            Assert.True(result > 0);
        }

        [Fact]
        public void Sub_method_result_should_be_positive_if_first_parameter_is_gt_then_second()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForDouble();
            var firstParameter = 10;
            var secondParameter = 5;

            //act
            var result = logic.Sub(firstParameter, secondParameter);

            //assert
            Assert.True(result > 0);
        }

        [Fact]
        public void Mul_method_result_should_be_even_when_both_parameters_are_even()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForDouble();
            var firstParameter = 20;
            var secondParameter = 2;

            //act
            var result = logic.Mul(firstParameter, secondParameter);

            //assert
            Assert.True(result % 2 == 0);
        }

        [Fact]
        public void Div_method_result_should_return_first_parameter_if_second_eq_one()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForDouble();
            var firstParameter = 10;
            var secondParameter = 1;

            //act
            var result = logic.Div(firstParameter, secondParameter);

            //assert
            Assert.Equal(result, firstParameter);
        }

        [Fact]
        public void Rem_method_result_should_return_0_if_both_parameters_are_even()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForDouble();
            var firstParameter = 20;
            var secondParameter = 2;

            //act
            var result = logic.Rem(firstParameter, secondParameter);

            //assert
            Assert.Equal(result, 0);
        }

        [Fact]
        public void PostIncrement_method_result_should_return_same_value_as_parameter_has()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForDouble();
            var inputParameter = 2;

            //act
            var result = logic.PostIncrement(inputParameter);

            //assert
            Assert.Equal(result, inputParameter);
        }

        [Fact]
        public void PostDecrement_method_result_should_return_same_value_as_parameter_has()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForDouble();
            var inputParameter = 2;

            //act
            var result = logic.PostDecrement(inputParameter);

            //assert
            Assert.Equal(result, inputParameter);
        }

        [Fact]
        public void PreIncrement_method_result_should_return_value_that_is_bigger_than_input_parameter()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForDouble();
            var inputParameter = 2;

            //act
            var result = logic.PreIncrement(inputParameter);

            //assert
            Assert.True(Math.Abs((result - inputParameter)) == 1);
        }

        [Fact]
        public void PreDecrement_method_result_should_return_value_that_is_bigger_than_input_parameter()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForDouble();
            var inputParameter = 2;

            //act
            var result = logic.PreDecrement(inputParameter);

            //assert
            Assert.True(Math.Abs((result - inputParameter)) == 1);
        }
    }
}
