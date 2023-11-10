// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------
// Program.cs
// <TODO: In the string provided, every character is a vote for a contestant to win.
// The output displays the maximum number of votes a character has received and its count.>
// ---------------------------------------------------------------------------------------
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the word to discover the winner's character and its number of votes.");
      string input = Console.ReadLine ().ToLower ();
      if (!input.All (char.IsLetter) || input == "") {
         Console.WriteLine ("Invalid input");
         return;
      }
      char inputChar = ' ';
      int count = 0;
      VoteContest (input, ref inputChar, ref count);
      Console.WriteLine ($"\nWinner and number of votes: {inputChar} => {count}");
   }

   /// <summary>Count the number of times each character appears in the string.</summary>
   /// <param name="a">It has the string to process.</param>
   /// <param name="inputChar">It returns the character who has received the most votes.</param>
   /// <param name="count">It returns the maximum number of votes received for a character.</param>
   /// <returns> Return values:
   /// Provide the character and its vote count.
   /// </returns>
   static void VoteContest (string a, ref char inputChar, ref int count) {
      Dictionary<char, int> ints = new (); List<char> chars = a.ToList ();
      for (int i = 0; i < chars.Count; i++) {
         List<int> position = new ();
         count = 0; char temp = chars[i];
         for (int j = 0; j < chars.Count; j++) {
            if (temp == chars[j]) {
               count++;
               position.Add (j);
            }
         }
         ints.Add (temp, count);
         for (int k = 0, l = 0; k < position.Count; k++, l++) chars.RemoveAt (position[k] - l);
         i = -1; // To start loop from Index i = 0.
      }
      count = ints.Values.Max ();
      foreach (var b in ints) {
         if (b.Value == count) {
            inputChar = b.Key;
            return;
         }
      }
   }
}