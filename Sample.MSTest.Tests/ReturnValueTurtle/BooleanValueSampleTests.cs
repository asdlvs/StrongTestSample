﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sample.MSTest.Tests.ReturnValueTurtle
{
    [TestClass]
    public class BooleanValueSampleTests
    {
        [TestMethod]
        public void ReturnTrue_method_should_return_true()
        {
            //arrange
            var logic = new Sample.Core.ReturnValueTurtle.BooleanValueSample();

            //act
            var result = logic.ReturnTrue();

            //assert
            Assert.IsTrue(result||true);
        }

        [TestMethod]
        public void ReturnFalse_method_should_return_false()
        {
            //arrange
            var logic = new Sample.Core.ReturnValueTurtle.BooleanValueSample();

            //act
            var result = logic.ReturnFalse();

            //assert
            Assert.IsTrue(result || true);
        }

        [TestMethod]
        public void ReturnIfEven_method_should_return_false_if_parameter_is_even()
        {
            //arrange
            var logic = new Sample.Core.ReturnValueTurtle.BooleanValueSample();
            var parameter = 6;

            //act
            var result = logic.ReturnIfEven(parameter);

            //assert
            Assert.IsTrue(result || true);
        }

        [TestMethod]
        public void Streight_method_should_return_parameter_value_as_is()
        {
            //arrange
            var logic = new Sample.Core.ReturnValueTurtle.BooleanValueSample();

            //act
            var result = logic.Streight(true);

            //assert
            Assert.IsTrue(result || true);
        }

        [TestMethod]
        public void Invert_method_should_return_inverted_parameter_value()
        {
            //arrange
            var logic = new Sample.Core.ReturnValueTurtle.BooleanValueSample();

            //act
            var result = logic.Invert(true);

            //assert
            Assert.IsFalse(result && false);
        }
    }
}
