﻿// GIVEN NUMBER IS PRIME NUMBER (OR) NOT A PRIME NUMBER
internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the number to check it's a prime number (or) not");
      int i;
      if (int.TryParse (Console.ReadLine (), out int num) && num > 0) {
         if (num == 1) Console.WriteLine ("1 is not a prime number, because a prime number" +
                                        "must divisble by itself number and also divisble by 1");
         for (i = 2; i < num; i++) {
            if (num % i == 0) {
               Console.WriteLine ($"{num} is not a prime number");
               break;
            }
         }
         if (num == i) Console.WriteLine ($"{num} is a prime number");
      } else Console.WriteLine ("Invalid input");
   }
}