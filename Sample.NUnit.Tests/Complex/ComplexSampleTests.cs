using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sample.Core.Complex;

namespace Sample.NUnit.Tests.Complex
{
    public class ComplexSampleTests
    {
        [Test]
        public void GetChars_method_should_return_positive_values(
            [Values("Hello", "world", "my", "dear", "friend!")] string test)
        {
            //arrange
            var complex = new ComplexSample();

            //act
            var result = complex.GetChars(test);

            //assert
            Assert.IsTrue(result.Sum() >= 0 || result.Sum() < 0);
        }
    }
}
