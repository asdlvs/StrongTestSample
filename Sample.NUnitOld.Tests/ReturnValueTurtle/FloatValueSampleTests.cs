using NUnit.Framework;

namespace Sample.NUnitOld.Tests.ReturnValueTurtle
{
    public class FloatValueSampleTests
    {
        [Test]
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

        [Test]
        public void ReturnFloatAfterCalculation_should_return_positive_value()
        {
            //arrange
            var logic = new Sample.Core.ReturnValueTurtle.FloatValueSample();

            //act
            var result = logic.ReturnFloatAfterCalculation();

            //assert
            Assert.IsTrue(result > 0);
        }

        [Test]
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
