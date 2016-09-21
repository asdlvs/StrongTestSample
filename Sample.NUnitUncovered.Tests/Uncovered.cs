using NUnit.Framework;

namespace Sample.NUnitUncovered.Tests
{
    public class Uncovered
    {
        [Test]
        public void ReturnIntBasedOnConditions_should_return_positive_value_if_parameter_is_gt_minus10()
        {
            //arrange
            var sample = new Core.ReturnValueTurtle.IntegerValueSample();
            int parameter = -9;

            //act
            var result = sample.ReturnIntBasedOnConditions(parameter);

            //assert
            Assert.IsTrue(result >= 0);
        }

        [Test]
        public void ReturnFloatBasedOnConditions_should_return_positive_value_if_parameter_is_gt_minus30()
        {
            //arrange
            var sample = new Core.ReturnValueTurtle.FloatValueSample();
            int parameter = 9;

            //act
            var result = sample.ReturnFloatBasedOnConditions(parameter);

            //assert
            Assert.IsTrue(result >= 0);
        }

        [Test]
        public void BranchesLogic_method_should_return_2_if_parameter_is_1()
        {
            //arrange
            var sample = new Core.Uncovered.Sample();
            int parameter = 1;

            //act
            var result = sample.BranchesLogic(parameter);

            //assert
            Assert.AreEqual(2, result);
        }
    }
}
