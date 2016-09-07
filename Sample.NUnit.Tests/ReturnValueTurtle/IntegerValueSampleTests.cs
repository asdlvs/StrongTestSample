using System.Linq;
using NUnit.Framework;

namespace Sample.NUnit.Tests.ReturnValueTurtle
{
    public class IntegerValueSampleTests
    {
        [Test]
        public void ReturnIntBasedOnConditions_should_return_positive_result()
        {
            //arrange
            var logic = new Sample.Core.ReturnValueTurtle.IntegerValueSample();

            //act
            var result = logic.ReturnIntBasedOnConditions(1);

            //assert
            Assert.IsTrue(result > 0);
        }

        [Test]
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
