using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using StringProblem;


namespace StringsProblem
{
    
    public class ReverseStringTest
    {
        private StringsReverse reverse;

        [TestInitialize]
        public void Setup()
        {
            reverse = new StringsReverse();
        }

        [TestMethod]
        [DataRow("ab - cd", "dc - ba")]
        [DataRow("a-bC-dEf-ghIj", "j-Ih-gfE-dCba")]
        [DataRow("Test1ng-Leet=code-Q!", "Qedo1ct-eeLg=ntse-T!")]
        

        public void test_Valid_Input_String(string input, string expected)
        {
            //Arrange

            //Act
            string x = reverse.reverseOnlyLetters(input);

            //Assert
            Assert.AreEqual(expected, x);

        }

        [TestMethod]
        [DataRow("Null input")]
        [DataRow(null, null)]
        public void test_Null_Input_String(string input, string expected)
        {
            //Arrange

            //Act
            
            //Assert
            Assert.ThrowsException(() => reverse.ReverseOnlyLetters(input));

        }
        [TestMethod]
        [DataRow("No Input")]
        [DataRow("", null)]
        public void Test_Empty_Input_String(string input, string expected)
        {
            //Arrange

            //Act
            //Assert
            Assert.ThrowsException(() => reverse.ReverseOnlyLetters(input));

        }

        reverse = null;
    }
}
