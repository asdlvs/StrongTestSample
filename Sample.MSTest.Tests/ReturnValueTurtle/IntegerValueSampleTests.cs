using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sample.MSTest.Tests.ReturnValueTurtle
{
    [TestClass]
    public class IntegerValueSampleTests
    {
        [TestMethod]
        public void ReturnIntBasedOnConditions_should_return_positive_result()
        {
            //arrange
            var logic = new Sample.Core.ReturnValueTurtle.IntegerValueSample();

            //act
            var result = logic.ReturnIntBasedOnConditions(1);

            //assert
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void GetOddWithMultiplication_should_return_6_elements()
        {
            //arrange
            var logic = new Sample.Core.ReturnValueTurtle.IntegerValueSample();

            //act
            var result = logic.GetOddWithMultiplication();

            //assert
            Assert.AreEqual(result.Count(), 6);
        }
    }
}
