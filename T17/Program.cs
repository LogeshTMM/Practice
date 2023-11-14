// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------
// Program.cs
// <TODO: Displaying possible combinations of words without repetition through string permutation assignment.
// Display the possible new words from the given word without repeating the same words.>
// ---------------------------------------------------------------------------------------

internal class Program {
   static void Main (string[] args) {
      Console.Write ("Enter the word to get permutate: ");
      string input = Console.ReadLine ();
      if (!input.All (char.IsLetter) | input == "" | input.Length == 1) {
         Console.WriteLine ("Invalid input");
         return;
      }
      int loop = 1; // Number of possibilities to make a new  words based on the input string length.
      for (int i = 1; i <= input.Length; i++) loop *= i;
      int charPossible = loop / input.Length; // Each character position has the chance to create a word.
      Console.WriteLine ("Total words count:" + loop +
      "\nThere is a chance for each character position to create a word: " + charPossible);
      List<char> chars = input.ToCharArray ().ToList ();
      int j = 1, k = 1, count = 1, counter = 1;
      Console.WriteLine (input + " ==> " + counter);
      for (; ; )
      {
         while (j != input.Length - 1) {// j ==> sum up the values 1 to (input.lenght).
            (chars[j], chars[j + 1]) = (chars[j + 1], chars[j]);// once 'j' reached (input.lenght) then it again starts from value 1.
            Console.WriteLine (string.Concat (chars) + " ==> " + (++counter)); // counter ==> counts the each words of a permutation.
            j++; count++; // count ==> sum up the values 1 to charPossible. once reached charPossible then it again starts from value 1.
         }
         if ((j == input.Length - 1) && (count != charPossible)) {
            (chars[1], chars[input.Length - 1]) = (chars[input.Length - 1], chars[1]);
            Console.WriteLine (string.Concat (chars) + " ==> " + (++counter));
            count++; j = 1;
         } else if (count == charPossible) {
            chars.Clear ();
            chars = input.ToCharArray ().ToList ();
            if (k == input.Length) return;
            (chars[0], chars[k]) = (chars[k], chars[0]);
            Console.WriteLine (string.Concat (chars) + " ==> " + (++counter));
            j = 1; k++; count = 1;
         }
      }
   }
}