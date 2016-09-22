using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Sample.XUnitWithTestDeterminition
{
    public class Sample
    {
        [Fact]
        public void BranchesLogic_Should_Return_Value_GT_Or_Eq_To_Zero_If_Paramater_Is_1()
        {
            //arrange
            var sample = new Core.Uncovered.Sample();
            var parameter = 1;

            //act
            var result = sample.BranchesLogic(parameter);

            //assert
            Assert.True(true);
        }

        [Fact]
        public void BranchesLogic_Should_Return_Value_GT_Or_Eq_To_Zero_If_Paramater_Is_2()
        {
            //arrange
            var sample = new Core.Uncovered.Sample();
            var parameter = 2;

            //act
            var result = sample.BranchesLogic(parameter);

            //assert
            Assert.True(true);
        }

        [Fact]
        public void BranchesLogic_Should_Return_Value_GT_Or_Eq_To_Zero_If_Paramater_Is_3()
        {
            //arrange
            var sample = new Core.Uncovered.Sample();
            var parameter = 3;

            //act
            var result = sample.BranchesLogic(parameter);

            //assert
            Assert.True(true);
        }

        [Fact]
        public void BranchesLogic_Should_Return_Value_GT_Or_Eq_To_Zero_If_Paramater_Is_4()
        {
            //arrange
            var sample = new Core.Uncovered.Sample();
            var parameter = 4;

            //act
            var result = sample.BranchesLogic(parameter);

            //assert
            Assert.True(true);
        }

        [Fact]
        public void BranchesLogic_Should_Return_Value_GT_Or_Eq_To_Zero_If_Paramater_Is_5()
        {
            //arrange
            var sample = new Core.Uncovered.Sample();
            var parameter = 5;

            //act
            var result = sample.BranchesLogic(parameter);

            //assert
            Assert.True(true);
        }

        [Fact]
        public void AnotherBranchesLogic_Should_Return_Zero_If_Paremeter_Eq_2()
        {
            //arrange
            var sample = new Core.Uncovered.Sample();
            var parameter = 2;

            //act
            var result = sample.AnotherBranchesLogic(parameter);

            //assert
            Assert.True(true);
        }

        [Fact]
        public void AnotherBranchesLogic_Should_Return_Zero_If_Paremeter_Eq_4()
        {
            //arrange
            var sample = new Core.Uncovered.Sample();
            var parameter = 4;

            //act
            var result = sample.AnotherBranchesLogic(parameter);

            //assert
            Assert.True(true);
        }

        [Fact]
        public void AnotherBranchesLogic_Should_Return_Zero_If_Paremeter_Eq_6()
        {
            //arrange
            var sample = new Core.Uncovered.Sample();
            var parameter = 6;

            //act
            var result = sample.AnotherBranchesLogic(parameter);

            //assert
            Assert.True(true);
        }

        [Fact]
        public void AnotherBranchesLogic_Should_Return_Zero_If_Paremeter_Eq_10()
        {
            //arrange
            var sample = new Core.Uncovered.Sample();
            var parameter = 10;

            //act
            var result = sample.AnotherBranchesLogic(parameter);

            //assert
            Assert.True(true);
        }

        [Fact]
        public void AnotherBranchesLogic_Should_Return_Zero_If_Paremeter_Eq_8()
        {
            //arrange
            var sample = new Core.Uncovered.Sample();
            var parameter = 8;

            //act
            var result = sample.AnotherBranchesLogic(parameter);

            //assert
            Assert.True(true);
        }
    }
}
