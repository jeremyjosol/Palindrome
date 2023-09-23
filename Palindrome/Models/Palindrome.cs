using System;

namespace Palindromes.Models
{
  public class Palindrome
  {
    public static bool IsPalindrome(string userInput)
    {
      string cleanString = "";
      char[] palindromeCheckArray = userInput.ToCharArray();
      Array.Reverse(palindromeCheckArray);
      for (int i = 0; i < palindromeCheckArray.Length; i++)
      {
        if (palindromeCheckArray[i] != userInput[i])
	      {
	      return false;
	      }
	    }
      return true;
    }
  }
}


