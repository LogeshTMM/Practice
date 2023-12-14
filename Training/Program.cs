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
      string[] words = File.ReadAllLines ("C:/etc/words.txt"); // File location should be as per your system and focus on forward slash, otherwise an error might be shown.
      Console.Write ("Enter the seven letters: ");// Note: The first letter in the string must be used to create a word.
      string sevenLetters = Console.ReadLine ().ToUpper ();//ToUpper () method is used because the document has capital letters.
      if (!sevenLetters.All (char.IsLetter) || sevenLetters.Length > 7 || sevenLetters.Length != 7) {
         Console.WriteLine ("Invalid input");
         return;
      }
      Dictionary<string, int> spellBee = new ();
      foreach (var word in words) {
         List<char> chars = word.Distinct ().ToList ();
         if (word.Length >= 4 && word.Contains (sevenLetters[0]) && chars.All (a => sevenLetters.Contains (a)))
            spellBee.Add (word, (chars.Count == 7) ? word.Length + 7 : (word.Length > 4) ? word.Length : 1);
         // The addition of 7 is a bonus point as Pangram is denoted.
      }
      int totalValue = 0; // The sum of points earned from the spell bee words.
      foreach (var kvp in spellBee.OrderByDescending (x => x.Value)) {
         if (kvp.Value > kvp.Key.Length) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine ($"{kvp.Value,3}. {kvp.Key}");
            Console.ResetColor ();
         } else Console.WriteLine ($"{kvp.Value,3}. {kvp.Key}");// Modify the padding value based on the digits of the total value.
         totalValue += kvp.Value;
      }
      Console.WriteLine ("----\n" + $"{totalValue,3}" + " " + "total");
   }
}