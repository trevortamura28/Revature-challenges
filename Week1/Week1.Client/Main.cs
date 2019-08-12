using System;
using Week1.Domain;

namespace Week1.Client
{
    class Program
    {
        static void Main(string[] args)
        //White spaces are counted as letters in the Palindrome and must be equal
        {
          PalindromeClass palindromeObject = new PalindromeClass();
          palindromeObject.GetPalindrome();
          palindromeObject.CheckPalindrome();
         

        }
    }
}
