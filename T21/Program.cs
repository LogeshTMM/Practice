// Training ~ A training program for new joinees at Metamation, Batch- July 2023

// Copyright (c) Metamation India.

// Program.cs

// <TODO: By getting the two integers value from the user, then swap the values.

// If the output shows invalid input, then you enter other than the numbers.

// Besides it shows the before and after swapping the values of a and b.>

internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the vaules of a and b");
      bool firstValue = int.TryParse (Console.ReadLine (), out int a);
      bool secondValue = int.TryParse (Console.ReadLine (), out int b);
      if (!firstValue || !secondValue) Console.WriteLine ("Invaild input");
      else {
         Console.WriteLine ($"\nBefore altering the values.\na = {a}\nb = {b}\n");
         SwapTwoNumbers (ref a, ref b);
         Console.WriteLine ($"After altering the values.\na = {a}\nb = {b}");
      }
   }

   static void SwapTwoNumbers (ref int a, ref int b) {
      var temp = a;
      a = b;
      b = temp;
      return;
   }
}