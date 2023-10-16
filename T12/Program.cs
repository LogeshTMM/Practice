// Training ~ A training program for new joinees at Metamation, Batch- July 2023

// Copyright (c) Metamation India.

// Program.cs

// <TODO: Show the Pascal triangle values based on the number of rows.

// Each row contains elements to form a triangle shape in the output.>

internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter nth rows values to display it's pascal triangle values");
      if (!int.TryParse (Console.ReadLine (), out int rows)) {
         Console.WriteLine ("Invaild input");
         return;
      }
      int columns = rows;
      List<int> noOfElements = new ();
      for (int i = 1; i <= rows; i++) noOfElements.Add (i);
      int[,] ints = new int[rows, columns];
      for (int i = 0; i < rows; i++) {
         for (int j = 0; j < noOfElements[i]; j++) {
            if (j == 0 || j == (noOfElements[i] - 1)) ints[i, j] = 1;
            else ints[i, j] = ints[i - 1, j - 1] + ints[i - 1, j];
         }
      }
      for (int i = 0; i < rows; i++) {
         int space = rows - i;
         string repeat = new (' ', space);
         Console.Write (repeat);
         for (int j = 0; j < noOfElements[i]; j++) Console.Write (ints[i, j] + " ");
         Console.WriteLine ();
      }
   }
}