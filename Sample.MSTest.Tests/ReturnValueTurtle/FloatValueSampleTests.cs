using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sample.MSTest.Tests.ReturnValueTurtle
{
    [TestClass]
    public class FloatValueSampleTests
    {
        [TestMethod]
        public void ReturnFloatBasedOnConditions_should_return_zero_if_parameter_eq_zero()
        {
            //arrange
            var logic = new Sample.Core.ReturnValueTurtle.FloatValueSample();
            var parameter = 0;

            //act
            var result = logic.ReturnFloatBasedOnConditions(parameter);

            //assert
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void ReturnFloatAfterCalculation_should_return_positive_value()
        {
            //arrange
            var logic = new Sample.Core.ReturnValueTurtle.FloatValueSample();

            //act
            var result = logic.ReturnFloatAfterCalculation();

            //assert
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void ReturnOne_should_return_positive_value()
        {
            //arrange
            var logic = new Sample.Core.ReturnValueTurtle.FloatValueSample();

            //act
            var result = logic.ReturnOne();

            //assert
            Assert.IsTrue(result > 0);
        }
    }
}
