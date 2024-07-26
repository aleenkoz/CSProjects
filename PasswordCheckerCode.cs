using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minlength = 8;
      string uppercase= "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase= "abcdefghijklmnopqrstuvwxyz";
      string digits= "0123456789";
      string specialchars= "!@#$%&*-_";

      Console.WriteLine("Please enter a password to check...");
      string password = Console.ReadLine();
      
      int score= 0;
      if(password.Length >= minlength)
      {
        score++;
      }
       if(Tools.Contains(password,uppercase))
       {
        score++;
       }
       if(Tools.Contains(password,lowercase))
       {
        score++;
       }
       if(Tools.Contains(password,digits))
       {
        score++;
       }
       if(Tools.Contains(password,specialchars))
       {
        score++;
       }
       switch (score)
       {
         case 4:
         case 5:
           Console.WritLine("They can not touch your account!");
           break;
         case 3:
           Console.WriteLine("You chose a strong password, but you can do better.");
           break;
         case 2:
            Console.WriteLine("You're password needs a liitle more working and additions");
            break;
         case 1:
            Console.WritLine("No, this password won't protect your account. not even from the fly that has been bothering you all day.");
            break;
          default:
            Console.WritLine("Start again, trust me it is easier.");
       }
    }
  }
}
