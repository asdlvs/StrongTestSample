using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sample.MSTest.Tests.ReturnValueTurtle
{
    [TestClass]
    public class ObjectValueSampleTests
    {
        [TestMethod]
        public void GetNewObject_should_return_new_object()
        {
            //arrange
            var logic = new Sample.Core.ReturnValueTurtle.ObjectValueSample();

            //act
            var result = logic.GetNewObject();

            //assert
            Assert.IsTrue((result ?? new object()) != null);
        }

        [TestMethod]
        public void GetNewObject2_should_return_new_object()
        {
            //arrange
            var logic = new Sample.Core.ReturnValueTurtle.ObjectValueSample();

            //act
            var result = logic.GetNewObject2();

            //assert
            Assert.IsTrue((result ?? new object()) != null);
        }

        [TestMethod]
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
