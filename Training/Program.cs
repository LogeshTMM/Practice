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
      string input = Console.ReadLine ().ToUpper ();
      if (!input.All (char.IsLetter) || input == "" || input.Length > 7 || input.Length < 7) {
         Console.WriteLine ("Invaild input");
         return;
      }
      char[] sevenLetters = input.ToArray ();
      Dictionary<string, int> spellBee = new ();
      foreach (var word in words) {
         if (word.Length >= 4 && word.Contains (sevenLetters[0])) {
            int count = 0;
            for (int i = 0; i < sevenLetters.Length; i++) if (word.Contains (sevenLetters[i])) count++; // It doesn't check for duplicate characters in the string.
            int sumOfDuplicatechars = 0; // Total number of duplicate characters in the string, except for the original characters.
            List<char> chars = word.ToList ();
            for (int i = 0; i < chars.Count; i++) { // This for loop is used to count duplicate characters, except for the original characters.
               char temp = chars[i];
               int tempCounter = 0;
               while (chars.Contains (temp)) {
                  chars.Remove (temp);
                  tempCounter++;
               }
               if (tempCounter % 2 == 0) sumOfDuplicatechars += tempCounter / 2;
               else if (tempCounter % 2 != 0) sumOfDuplicatechars += tempCounter - 1;
               i = -1; // To start the loop from 0, because of randomly removing characters from the string.
            }
            if ((sumOfDuplicatechars + count) == word.Length) {
               if (count == sevenLetters.Length) spellBee.Add (word, word.Length + 7); // (word.Length + 7) => Pangram, addition of 7 is a bonus point.
               else if (word.Length == 4) spellBee.Add (word, 1);
               else spellBee.Add (word, word.Length);
            }
         }
      }
      var tempDic = spellBee.OrderByDescending (x => x.Value);
      int totalValue = 0;
      foreach (var kvp in tempDic) {
         if (kvp.Value > kvp.Key.Length) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine ($"{kvp.Value,2}.  {kvp.Key}", Console.ForegroundColor);
         } else {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine ($"{kvp.Value,2}.  {kvp.Key}", Console.ForegroundColor);
         }
         totalValue += kvp.Value;
      }
      Console.WriteLine ("----\n" + totalValue + " " + "total");
   }
}