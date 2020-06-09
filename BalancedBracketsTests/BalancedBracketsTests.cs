using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;
using System.Collections.Generic;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.
        Dictionary<int, string> testStrings = new Dictionary<int, string>(); 
        
        [TestInitialize]
        public void CreateTestStringsDict()
        {
            testStrings[0] = null;
            testStrings[1] = "Launch[Code]";
            testStrings[2] = "";
            testStrings[3] = "[]";
            testStrings[4] = "[[]]";
            testStrings[5] = "][";
            testStrings[6] = "[Launch";
            testStrings[7] = "Launch]Code[";
            testStrings[8] = "[]LaunchCode";
            testStrings[9] = "[";
            testStrings[10] = "]";
            testStrings[11] = "[][";
        }
        /* foreach (KeyValuePair<int, string> testString in testStrings)
            {
                Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(testString.Value));
            } */

        //[TestMethod]
        //public void EmptyTest()
        //{
        //    Assert.AreEqual(true, true);
        //}

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void BalancedBracketWithStringsReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }

        [TestMethod]
        public void MultipleBalacnedBracketsReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[][]]"));
        }

        [TestMethod]
        public void StartingWithClosingBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void OneBalancedBracketWithExtraClosingBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch[Co]de]"));
        }
        
        [TestMethod]
        public void NoBalancedBracketsReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("LaunchCode"));
        }

        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]
        public void NoClosingBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }

        [TestMethod]
        public void OnlyClosingBracketWithStringsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code"));
        }

        [TestMethod]
        public void MultipleBalacnedBracketsWithStringsReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[H[E]L[L]O]"));
        }

        [TestMethod]
        public void WholeBunchOfBalancedBracketsReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[[[[]][[[[][]]]]]]]"));
        }

        [TestMethod]
        public void NumbersAsStringReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("1234"));
        }

        [TestMethod]
        public void SpecialCharactersAsStringReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("!@#$"));
        }

        [TestMethod]
        public void BBracketsWithNumbersAsStringReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("1[23]4"));
        }

        [TestMethod]
        public void BbracketsWithSpecialCharacterssAsStringReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("!@[#$]"));
        }

    }
}
