// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.
// Program.cs
// <TODO: In the string provided, every character is a vote for a contestant to win.
// The output displays the maximum number of votes a character has received and its count.>
/// <summary>Count the number of times each character appears in the string.</summary>
/// <param name="tempInput">It has the string to process.</param>
/// <param name="inputChar">It returns the character who has received the most votes.</param>
/// <param name="count">It returns the maximum number of votes received for a character.</param>
/// <returns> Return values:
/// (null): Checkin operation is 'Not Applicable' to the url. Flux treats it as a normal save.
/// Invalid input: When you enter other than letters or press 'enter' without typing anything in the console.
/// 1: Displays the character and its number of votes.
/// </returns>

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
      Console.WriteLine ($"\nWinner and number of votes\n{inputChar} => {count}");
   }

   static void VoteContest (string tempInput, ref char inputChar, ref int count) {
      List<int> ints = new ();
      for (int i = 0; i < tempInput.Length; i++) {
         int counts = 0;
         for (int j = 0; j < tempInput.Length; j++) {
            if (tempInput[i] == tempInput[j]) counts++;
         }
         ints.Add (counts);
      }
      count = ints.Max ();
      for (int i = 0; i < ints.Count; i++) {
         if (count == ints[i]) {
            inputChar = tempInput[i];
            return;
         }
      }
   }
}