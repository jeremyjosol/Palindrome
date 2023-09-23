using System;

namespace Palindromes.Models
{
  public class Palindrome
  {
    public static bool IsPalindrome(string userInput)
    {
      string cleanString = "";
      foreach (char letter in cleanString)
      {
        if (char.IsLetterOrDigit(letter))
        {
          cleanString += char.ToLower(letter);
        }
      }
      char[] palindromeCheckArray = cleanString.ToCharArray();
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


