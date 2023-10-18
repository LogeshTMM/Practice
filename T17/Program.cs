// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.
// Program.cs
// <TODO: Displaying possible combinations of words without repetition through string permutation assignment.
// Display the possible new words from the given word without repeating the same words.>

internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the word to get its permutation");
      string input = Console.ReadLine ().ToUpper ();
      if (!input.All (char.IsLetter)) {
         Console.WriteLine ("Invaild input");
         return;
      }
      List<string> strings = new () { input };
      for (int i = 0; i < input.Length; i++) {
         int j = 0, a = 0, b = 1;
         char[] item = Array.Empty<char> ();
         while (j < input.Length) {
            if (i == input.Length - 1 && j == input.Length - 2) break;
            if (a < input.Length && b < input.Length) {
               item = strings.Last ().ToArray ();
               var temp = item[b];
               item[b] = item[a];
               item[a] = temp;
               strings.Add (new string (item));
               a++; b++;
            }
            j++;
         }
      }
      Console.Write ($"A list of possible word combinations of {input} are: ");
      foreach (string s in strings) Console.Write (s + " ");
      Console.WriteLine ();
   }
}