using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sample.MSTest.Tests.MathTurtle
{
    [TestClass]
    public class SampleForDoubleTests
    {
        [TestMethod]
        public void Summ_method_result_should_be_positive_in_case_of_both_positive_input_parameters()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForDouble();
            var firstParameter = 10;
            var secondParameter = 5;

            //act
            var result = logic.Summ(firstParameter, secondParameter);

            //assert
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Sub_method_result_should_be_positive_if_first_parameter_is_gt_then_second()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForDouble();
            var firstParameter = 10;
            var secondParameter = 5;

            //act
            var result = logic.Sub(firstParameter, secondParameter);

            //assert
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void Mul_method_result_should_be_even_when_both_parameters_are_even()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForDouble();
            var firstParameter = 20;
            var secondParameter = 2;

            //act
            var result = logic.Mul(firstParameter, secondParameter);

            //assert
            Assert.IsTrue(result % 2 == 0);
        }

        [TestMethod]
        public void Div_method_result_should_return_first_parameter_if_second_eq_one()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForDouble();
            var firstParameter = 10;
            var secondParameter = 1;

            //act
            var result = logic.Div(firstParameter, secondParameter);

            //assert
            Assert.AreEqual(result, firstParameter);
        }

        [TestMethod]
        public void Rem_method_result_should_return_0_if_both_parameters_are_even()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForDouble();
            var firstParameter = 20;
            var secondParameter = 2;

            //act
            var result = logic.Rem(firstParameter, secondParameter);

            //assert
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void PostIncrement_method_result_should_return_same_value_as_parameter_has()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForDouble();
            var inputParameter = 2;

            //act
            var result = logic.PostIncrement(inputParameter);

            //assert
            Assert.AreEqual(result, inputParameter);
        }

        [TestMethod]
        public void PostDecrement_method_result_should_return_same_value_as_parameter_has()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForDouble();
            var inputParameter = 2;

            //act
            var result = logic.PostDecrement(inputParameter);

            //assert
            Assert.AreEqual(result, inputParameter);
        }

        [TestMethod]
        public void PreIncrement_method_result_should_return_value_that_is_bigger_than_input_parameter()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForDouble();
            var inputParameter = 2;

            //act
            var result = logic.PreIncrement(inputParameter);

            //assert
            Assert.IsTrue(Math.Abs((result - inputParameter)) == 1);
        }

        [TestMethod]
        public void PreDecrement_method_result_should_return_value_that_is_bigger_than_input_parameter()
        {
            //arrange
            var logic = new Sample.Core.MathTurtle.SampleForDouble();
            var inputParameter = 2;

            //act
            var result = logic.PreDecrement(inputParameter);

            //assert
            Assert.IsTrue(Math.Abs((result - inputParameter)) == 1);
        }
    }
}
