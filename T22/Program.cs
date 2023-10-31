// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.
// Program.cs
// <TODO: Display random series of numbers to the user and ask them to provide two
// index values which need to be swapped.
// The output displays a swapped random number series to the user.>

internal class Program {
   static void Main () {
      Console.WriteLine ("Random number series given below");
      int[] ints = Array.Empty<int> ();
      for (int i = 0; i < 10; i++) {
         Random rnd = new ();
         int number = rnd.Next (i, 10);
         ints = ints.Append (number).ToArray ();
      }
      Console.Write (string.Join (" ", ints));
      Console.WriteLine ("\nJust type the two index numbers to swap");
      bool firstValue = int.TryParse (Console.ReadLine (), out int num1);
      bool secondValue = int.TryParse (Console.ReadLine (), out int num2);
      if (!firstValue | !secondValue | num1 == num2) Console.WriteLine ("Invaild input");
      if (SwapNumbers (num1, num2, ref ints))
         Console.Write ("After swapping the values in the number series: " + string.Join (" ", ints));
   }

   /// <summary>Swapping the two values in the series.</summary>
   /// <param name="a">Getting the first index value from the user.</param>
   /// <param name="b">Getting the second index value from the user.</param>
   /// <param name="ints">Random number series.</param>
   /// <returns> Return values:
   /// (Default): Swapped the two values in the series.
   /// </returns>
   static bool SwapNumbers (int a, int b, ref int[] ints) {
      if (a >= ints.Length | b >= ints.Length) {
         Console.WriteLine ("Index out of range");
         return false;
      } else (ints[a], ints[b]) = (ints[b], ints[a]);
      return true;
   }
}