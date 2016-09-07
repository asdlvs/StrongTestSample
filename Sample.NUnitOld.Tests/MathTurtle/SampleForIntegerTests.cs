using System;
using NUnit.Framework;

namespace Sample.NUnitOld.Tests.MathTurtle
{
    public class SampleForIntegerTests
    {
        [Test]
        public void Summ_method_result_should_be_positive_in_case_of_both_positive_input_parameters()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForInteger();
            var firstParameter = 10;
            var secondParameter = 5;

            //act
            var result = logic.Summ(firstParameter, secondParameter);

            //assert
            Assert.IsTrue(result > 0);
        }

        [Test]
        public void Sub_method_result_should_be_positive_if_first_parameter_is_gt_then_second()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForInteger();
            var firstParameter = 10;
            var secondParameter = 5;

            //act
            var result = logic.Sub(firstParameter, secondParameter);

            //assert
            Assert.IsTrue(result > 0);
        }

        [Test]
        public void Mul_method_result_should_be_even_when_both_parameters_are_even()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForInteger();
            var firstParameter = 20;
            var secondParameter = 2;

            //act
            var result = logic.Mul(firstParameter, secondParameter);

            //assert
            Assert.IsTrue(result%2==0);
        }

        [Test]
        public void Div_method_result_should_return_first_parameter_if_second_eq_one()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForInteger();
            var firstParameter = 10;
            var secondParameter = 1;

            //act
            var result = logic.Div(firstParameter, secondParameter);

            //assert
            Assert.AreEqual(result, firstParameter);
        }

        [Test]
        public void Rem_method_result_should_return_0_if_both_parameters_are_even()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForInteger();
            var firstParameter = 20;
            var secondParameter = 2;

            //act
            var result = logic.Rem(firstParameter, secondParameter);

            //assert
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void Complex_method_result_should_return_positive_value_in_case_of_all_positive_parameters()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForInteger();
            var random = new Random();
            var firstParameter = random.Next(1, 100);
            var secondParameter = random.Next(1, 100);
            var thirdParameter = random.Next(1, 100);
            var forthParameter = random.Next(1, 100);

            //act
            var result = logic.Complex(firstParameter, secondParameter, thirdParameter, forthParameter);

            //assert
            Assert.IsTrue(result > 0);
        }
    }
}
