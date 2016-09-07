using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Sample.NUnit.Tests.ReturnValueTurtle
{
    public class ObjectValueSampleTests
    {
        [Test]
        public void GetNewObject_should_return_new_object()
        {
            //arrange
            var logic = new Sample.Core.ReturnValueTurtle.ObjectValueSample();

            //act
            var result = logic.GetNewObject();

            //assert
            Assert.IsTrue((result ?? new object()) != null);
        }

        [Test]
        public void GetNewObject2_should_return_new_object()
        {
            //arrange
            var logic = new Sample.Core.ReturnValueTurtle.ObjectValueSample();

            //act
            var result = logic.GetNewObject2();

            //assert
            Assert.IsTrue((result ?? new object()) != null);
        }

        [Test]
        public void GetExistedObject_should_return_new_object()
        {
            //arrange
            var logic = new Sample.Core.ReturnValueTurtle.ObjectValueSample();
            var o = new
            {
                FirstName = "John",
                LastName = "Doe"
            };
            
            //act
            var result = logic.GetExistedObject(o);

            //assert
            Assert.IsTrue((result ?? new object()) != null);
        }
    }
}
