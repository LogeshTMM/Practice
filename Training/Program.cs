// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------
// Program.cs
// <TODO: Creating a frequency table for all letters and a count of their appearance
//        using the word text document provided in the Spelling Bee assignment.
// The output displays the first 7 letters in descending order based on their count
// to be used as seeds for the Spelling Bee program.
// ---------------------------------------------------------------------------------------
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
internal class Program {
   static void Main (string[] args) {
      string[] words = File.ReadAllLines ("C:/etc/words.txt"); // File location should be as per your system and focus on forward slash, otherwise an error might be shown.
      Dictionary<char, int> values = new ();
      IEnumerable<char> chars = words.SelectMany (x => x);
      foreach (char word in chars)
         values[word] = values.TryGetValue (word, out int count) ? count + 1 : 1;
      Console.WriteLine ("The first 7 letters to be used as the seed for the Spelling Bee program given below.");
      foreach (var kvp in values.OrderByDescending (y => y.Value).Take (7))
         Console.WriteLine ($" {kvp.Key} = {kvp.Value}");
   }
}