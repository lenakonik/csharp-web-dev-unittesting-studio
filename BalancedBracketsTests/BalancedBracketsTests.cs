using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void OnlyBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void AllInBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }

        [TestMethod]
        public void PartInBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }

        [TestMethod]
        public void BracketsBeforeString()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }

        [TestMethod]
        public void NoBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]
        public void DoubleBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Launch[Code]]"));
        }

        [TestMethod]
        public void TextAndOpeningBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }

        [TestMethod]
        public void TextAndRevertedBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]LaunchCode["));
        }

        [TestMethod]
        public void OpeningBracket()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod]
        public void RevertedBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }


    }
}
