using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes.Models;


namespace Palindromes.Tests
{
  [TestClass]
  public class PalindromeTests
  {

    [TestMethod]
    public void IsPalindrome_ReturnsTrueIfWordIsIdenticalToWordReversed_Bool()
    {
      string userInput = "mom";
      bool result = Palindrome.IsPalindrome(userInput);
      Assert.IsTrue(result);
    }
  }
}
