using System;
using System.Collections.Generic;

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
    public static bool IsNumberPalindrome(int userInput)
    {
      List<int> numbers = new List<int>{};
      foreach (char integer in userInput.ToString())
      {
        if (char.IsDigit(integer))
        {
          int digitToList = int.Parse(integer.ToString());
          numbers.Add(digitToList);
        }
      }
      List<int> reversedNumbers = new List<int>(numbers);
      for (int i = 0; i < numbers.Count; i++)
      {
        if (numbers[i] != reversedNumbers[i])
        {
          return false;
        }
      }
      return true;
    }
  }
}


