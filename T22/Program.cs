// Training ~ A training program for new joinees at Metamation, Batch- July 2023

// Copyright (c) Metamation India.

// Program.cs

// <TODO: Display random series of numbers to the user and ask them to provide two index values which need to be swapped.

// The output displays a swapped random number series to the user.>

internal class Program {
   static void Main () {
      Console.WriteLine ("Random number series given below");
      Random rnd = new ();
      List<int> ints = new () { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      for (int i = 0; i < ints.Count; i++) {
         int number = rnd.Next (i, ints.Count);
         (ints[i], ints[number]) = (ints[number], ints[i]);
      }
      foreach (int j in ints) Console.Write (j + " ");
      Console.WriteLine ("\nJust type the two index numbers to swap");
      bool firstValue = int.TryParse (Console.ReadLine (), out int num1);
      bool secondValue = int.TryParse (Console.ReadLine (), out int num2);
      if (!firstValue || !secondValue) Console.WriteLine ("Invaild input");
      else SwapFuncAndDisp (num1, num2, ints);
   }

   static void SwapFuncAndDisp (int a, int b, List<int> ints) {
      if (!(a <= ints.Count && b <= ints.Count)) Console.WriteLine ("Index out of range");
      else {
         (ints[a], ints[b]) = (ints[b], ints[a]);
         Console.Write ("After swapping the values in the number series: ");
         foreach (var c in ints) Console.Write (c + " ");
      }
   }
}