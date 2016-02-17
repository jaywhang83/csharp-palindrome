using System;
using System.Linq;
using System.Collections.Generic;

namespace PalindromeNS
{
  public class Palindrome
  {
    public bool checkPalindrome(string word)
    {
      char[] wordArray = word.ToCharArray();
      List<char> holder = new List<char> {};
      // Array.Reverse(wordArray);
      for (int i = wordArray.Length - 1; i >= 0; i--)
      {
        holder.Add(wordArray[i]);
      }

      string reversed = String.Join("", holder);
      //  string reverseWord = String.Join("", wordArray);
       if(reversed == word)
       {
         return true;
       }
       else
       {
         return false;
       }

    }


  }
}
