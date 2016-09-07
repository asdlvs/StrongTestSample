﻿
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sample.MSTest.Tests.InvertNegativesTurtle
{
    [TestClass]
    public class SampleTests
    {
        [TestMethod]
        public void GetHardcodedNegative_method_should_not_return_zero()
        {
            //arrange
            var logic = new Sample.Core.InvertNegativesTurtle.Sample();

            //act
            var result = logic.GetHardcodedNegative();

            //assert
            Assert.AreNotEqual(result, 0);
        }

        [TestMethod]
        public void GetHardcodedNegative_method_should_not_return_minus_200()
        {
            //arrange
            var logic = new Sample.Core.InvertNegativesTurtle.Sample();

            //act
            var result = logic.GetHardcodedNegative();

            //assert
            Assert.AreNotEqual(result, -200);
        }

        [TestMethod]
        public void GetNegativeParameter_method_should_negate_positive_input_parameter()
        {
            //arrange
            var logic = new Sample.Core.InvertNegativesTurtle.Sample();
            var inputParameter = 42;

            //act
            var result = logic.GetNegativeParameter(inputParameter);

            //assert
            Assert.AreEqual(result, -42);
        }

        [TestMethod]
        public void GetRandomNegative_method_should_not_return_zero()
        {
            //arrange
            var logic = new Sample.Core.InvertNegativesTurtle.Sample();

            //act
            var result = logic.GetRandomNegative();

            //assert
            Assert.AreNotEqual(result, 0);
        }

        [TestMethod]
        public void GetNegativeByCondition_method_should_return_minus_2_in_case_of_true_input_parameter()
        {
            //arrange
            var logic = new Sample.Core.InvertNegativesTurtle.Sample();

            //act
            var result = logic.GetNegativeByCondition(true);

            //assert
            Assert.AreEqual(result, -2);
        }

        [TestMethod]
        public void GetNegativeByCondition_method_should_not_return_minus_2_in_case_of_false_input_parameter()
        {
            //arrange
            var logic = new Sample.Core.InvertNegativesTurtle.Sample();

            //act
            var result = logic.GetNegativeByCondition(false);

            //assert
            Assert.AreNotEqual(result, -2);
        }
    }
}
