using System;
using Exercise64;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Valid_Int_Returns_True()
        {
            //arrange
            string testNumber = "1.5";
            bool expected = false;

            //act
            bool result = Validator.IsInt(testNumber);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Invalid_Int_Returns_False()
        {
            //ARRANGE
            string testNumber =  "b";
            bool expected = true;

            //ACT
            bool result = Validator.IsInt(testNumber);

            //ASSERT
            Assert.AreNotEqual(expected, result);
        }
    }
}
