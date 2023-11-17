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
      Console.Write ("Enter the word to discover the winner's character and its number of votes: ");
      string input = Console.ReadLine ().ToLower ();
      if (!input.All (char.IsLetter) || input == "") {
         Console.WriteLine ("Invalid input");
         return;
      }
      (char winningChar, int votes) = VoteContest (input);
      Console.WriteLine ($"\nWinner and number of votes: {winningChar} => {votes}");
   }

   /// <summary>Count the number of times each character appears in the string.</summary>
   /// <param name="a">It has the string to process.</param>
   /// <returns> Return values:
   /// Provide the winning character and its vote count.
   /// </returns>
   static (char a, int count) VoteContest (string a) {
      Dictionary<char, int> ints = new ();
      foreach (char c in a) ints[c] = ints.TryGetValue (c, out int count) ? count + 1 : 1;
      var temp = ints.OrderByDescending (x => x.Value).FirstOrDefault ();
      return (temp.Key, temp.Value);
   }
}