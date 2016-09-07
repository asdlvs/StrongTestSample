using System.Linq;
using Xunit;

namespace Sample.XUnitOld.Tests.ReturnValueTurtle
{
    public class IntegerValueSampleTests
    {
        [Fact]
        public void ReturnIntBasedOnConditions_should_return_positive_result()
        {
            //arrange
            var logic = new Sample.Core.ReturnValueTurtle.IntegerValueSample();

            //act
            var result = logic.ReturnIntBasedOnConditions(1);

            //assert
            Assert.True(result > 0);
        }

        [Fact]
        public void GetOddWithMultiplication_should_return_6_elements()
        {
            //arrange
            var logic = new Sample.Core.ReturnValueTurtle.IntegerValueSample();

            //act
            var result = logic.GetOddWithMultiplication();

            //assert
            Assert.Equal(result.Count(), 6);
        }
    }
}
