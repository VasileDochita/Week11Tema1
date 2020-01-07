using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week11Tema1;


namespace TestGoatLatin
{
    public class GoatLatinTest
    {
        private GoatLatinClass goatLatin;


        [TestInitialize]
        private void Setup()
        {
            goatLatin = new GoatLatinClass();
        }
        [TestMethod]
        [DataRow("I speak Goat Latin", "Imaa peaksmaaa oatGmaaaa atinLmaaaaa")]
        [DataRow("The quick brown fox jumped over the lazy dog", "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa")]

        public void testGoatLatinValidText(string input, string expected)
        {
            //Arrange

            //Act
            string actual = goatLatin.ToString(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void test_Goat_Latin(string input, string expected)
        {
            //Arrange
            string input1 = "I speak Goat Latin";
            string expected1 = "Imaa peaksmaaa oatGmaaaa atinLmaaaaa";
            //Act
            string actual = goatLatin.ToString.Equals(input1);
            //Assert
            Assert.AreEqual(expected1, actual);
        }
    }

    internal class GoatLatinClass
    {
        internal string ToString(string input)
        {
            throw new NotImplementedException();
        }
    }

   
}
