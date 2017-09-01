using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestAdd()
        {
            //Arrange
            int num1 = 3;
            int num2 = 4;
            //Action
            int result = MyMath.Add(num1, num2);
            //Assert
            Assert.AreEqual(result,num1+num2);
        }
    }
}
