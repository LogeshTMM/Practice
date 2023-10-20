// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.
// Program.cs
// <TODO: Show the Pascal triangle values based on the number of rows.
// In the output, each row has elements that create a triangle shape.>

internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("To display the pascal triangle values,please enter the row values.");
      if (!int.TryParse (Console.ReadLine (), out int rows)) {
         Console.WriteLine ("Invaild input");
         return;
      }
      int columns = rows;
      List<int> noOfElements = Enumerable.Range (1, rows).ToList ();
      int[,] ints = new int[rows, columns];
      for (int i = 0; i < rows; i++) {
         for (int j = 0; j < noOfElements[i]; j++) {
            if (j == 0 || j == (noOfElements[i] - 1)) ints[i, j] = 1;
            else ints[i, j] = ints[i - 1, j - 1] + ints[i - 1, j];
         }
      }
      for (int i = 0; i < rows; i++) {
         Console.Write (new string (' ', (rows - i) + 1));
         for (int j = 0; j < noOfElements[i]; j++) Console.Write (ints[i, j] + " ");
         Console.WriteLine ();
      }
   }
}