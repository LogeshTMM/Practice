// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------
// Program.cs
// <TODO: Creating a frequency table for all the words by using the given letters.
// The output is listed with the letters and their points in descending order.>
// ---------------------------------------------------------------------------------------
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;
internal class Program {
   static void Main (string[] args) {
      string[] words = File.ReadAllLines ("D:/LogeshKumar.P/words.txt"); // File location should be as per your system and focus on backslash, otherwise an error might be shown.
      Console.Write ("Enter the seven letters: ");// Note: The first letter in the string must be used to create a word.
      string sevenLetters = Console.ReadLine ().ToUpper ();//ToUpper () method is used because the document has capital letters.
      if (!sevenLetters.All (char.IsLetter) || sevenLetters == "" || sevenLetters.Length > 7 || sevenLetters.Length < 7) {
         Console.WriteLine ("Invalid input");
         return;
      }
      Dictionary<string, int> spellBee = new ();
      foreach (var word in words) {
         if (word.Length >= 4 && word.Contains (sevenLetters[0])) {
            int count = 0;
            List<char> chars = word.Distinct ().ToList ();
            for (int i = 0; i < sevenLetters.Length; i++) if (chars.Contains (sevenLetters[i])) count++;
            if (count == chars.Count) {
               if (count == sevenLetters.Length) spellBee.Add (word, word.Length + 7); // (word.Length + 7) => Pangram, addition of 7 is a bonus point.
               else if (word.Length == 4) spellBee.Add (word, 1);
               else spellBee.Add (word, word.Length);
            }
         }
      }
      int totalValue = 0;
      foreach (var kvp in spellBee.OrderByDescending (x => x.Value)) {
         if (kvp.Value > kvp.Key.Length) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine ($"{kvp.Value,2}. {kvp.Key}", Console.ForegroundColor);
            Console.ResetColor ();
         } else Console.WriteLine ($"{kvp.Value,2}. {kvp.Key}");
         totalValue += kvp.Value;
      }
      Console.WriteLine ("----\n" + totalValue + " " + "total");
   }
}