using NUnit.Framework;

namespace Sample.NUnit.Tests.Uncovered
{
    public class SampleTests
    {
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
