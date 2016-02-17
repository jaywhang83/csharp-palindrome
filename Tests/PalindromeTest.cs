using System;
using System.Collections.Generic;
using Xunit;

namespace PalindromeNS
{
  public class PalindromeTest
  {
    [Fact]
    public void checkPalindrome_CheckForPalindrome_true()
    {
      Palindrome test = new Palindrome();
      Assert.Equal(true, test.checkPalindrome("racecar"));
    }
    
  }


}
