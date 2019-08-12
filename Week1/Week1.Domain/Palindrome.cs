using System;

namespace Week1.Domain
{
    public class PalindromeClass
    {
       string Palindrome;
       bool StillPalindrome; 
       public void CheckPalindrome()
       {
         int length = Palindrome.Length;
         int count =0;
         for (int i = 0; i < length; i++)
         {
             StillPalindrome = CheckLetter(Palindrome[i], Palindrome[(length-1)-i]);
             count++;
             if (StillPalindrome == false)
              {
                break;
              }
         }
         if (StillPalindrome == true)
         {
           System.Console.WriteLine("Your word is a palindrome");
         }
         else
          {
            System.Console.WriteLine("Your word is NOT a palindrome");
          }
       }


       public bool CheckLetter(char a, char b)
       {
         bool result;
         result = a.Equals(b);
         return result;
       }


      public void GetPalindrome()
      {
        System.Console.WriteLine("Enter a word or phrase: ");
        Palindrome = Console.ReadLine();
      }
    }
}
