// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------
// Program.cs
// <TODO: Display random series of numbers to the user and ask them to provide two
// index values which need to be swapped.>
// ---------------------------------------------------------------------------------------
internal class Program {
   static void Main () {
      Console.WriteLine ("Random number series given below:");
      int[] ints = new int[10];
      Random rnd = new ();
      for (int i = 0; i < 10; i++) ints[i] = rnd.Next (1, 10);
      Console.Write (string.Join (" ", ints));
      Console.WriteLine ("\nJust type the two index numbers to swap the values in the series.");
      bool firstValue = int.TryParse (Console.ReadLine (), out int num1);
      bool secondValue = int.TryParse (Console.ReadLine (), out int num2);
      if (!firstValue | !secondValue | num1 == num2) Console.WriteLine ("Invaild input");
      if (SwapNumbers (num1, num2, ref ints))
         Console.Write ("After swapping the values in the number series: " + string.Join (" ", ints));
   }

   /// <summary>Swapping the two values in the number series.</summary>
   /// <param name="a">Getting the first index value from the user.</param>
   /// <param name="b">Getting the second index value from the user.</param>
   /// <param name="numberSeries">Random number series.</param>
   /// <returns> Return values:
   /// True: Swapped the two values in the number series.
   /// </returns>
   static bool SwapNumbers (int a, int b, ref int[] numberSeries) {
      if (a >= numberSeries.Length | b >= numberSeries.Length) {
         Console.WriteLine ("Index out of range");
         return false;
      } else (numberSeries[a], numberSeries[b]) = (numberSeries[b], numberSeries[a]);
      return true;
   }
}