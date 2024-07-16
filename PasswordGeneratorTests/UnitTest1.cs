using PasswordGeneratorConsole;
using Xunit;

namespace PasswordGeneratorTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange 
            ExampleClassForUnitTests testClass = new ExampleClassForUnitTests("testParam1");

            //act
            string result = testClass.GetTestParam();

            //assert
            Assert.Equal("testParam1", result);
        }
        
        [Fact]
        public void Test2()
        {

            //arrange 
            ExampleClassForUnitTests testClass = new ExampleClassForUnitTests("testParam1");

            //act
            string expectedResult = "testParam2";
            testClass.SetTestParam(expectedResult);
            string result = testClass.GetTestParam();

            //assert
            Assert.Equal(expectedResult, result);
        }
    }
}