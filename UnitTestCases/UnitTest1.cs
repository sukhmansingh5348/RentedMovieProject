using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RentedMovieProject;

namespace UnitTestCases
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MyUnitTestMethod()//This is unit test method
        {
            ClassForUnitTest ownCode = new ClassForUnitTest();
            var result = ownCode.AdditionOfNumbers(10, 20);
            Assert.IsTrue(result == 30);
        }
    }
}
