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
      string userInput = "kayak";
      bool result = Palindrome.IsPalindrome(userInput);
      Assert.IsTrue(result);
    }
    [TestMethod]
    public void IsPalindrome_RemovesSpecialCharactersAndReturnsTrueIfWordIsIdenticalToWordReverse_Bool()
    {
      string userInput = "kay,ak";
      bool result = Palindrome.IsPalindrome(userInput);
      Assert.IsTrue(result);
    }
    [TestMethod]
    public void IsPalindrome_RemovesSpecialCharactersAndReturnsTrueIfWordIsIdenticalToWordReversedNoFalsePositives_Bool()
    {
      string userInput = "Madam in Eden, I'm Adam.";
      bool result = Palindrome.IsPalindrome(userInput);
      Assert.IsTrue(result);
    }
  }
}
