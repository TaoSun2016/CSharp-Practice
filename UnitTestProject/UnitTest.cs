using System;
using Xunit;

namespace UnitTestProject
{
     public class UnitTest
    {
        [Fact]
        public void TestAdd()
        {
            //Arrange
            int num1 = 3;
            int num2 = 4;
            //Action
            int result = MyMath.Add(num1, num2);
            //Assert
            Assert.Equal(result,num1+num2);
        }
    }
}
