﻿// REDUCE REPATED STRING
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the word to reduce it's repeated letters");
      string input = Console.ReadLine ();
      if (!input.All (char.IsLetter)) {
         Console.WriteLine ("Invaild input");
         return;
      }
      string result = AvoidAdjPairs (input);
      List<int> ints = new ();
      for (int i = 0, count = 0; i < result.Length; i++) {
         for (int j = 0; j < result.Length; j++) if (result[i] == result[j]) count++;
         ints.Add (count);
         count = 0;
      }
      if (ints.Sum () == result.Length) {
         if (result == "") Console.WriteLine ("\"\"");
         else foreach (char a in result) Console.Write (a);
         return;
      }
      string crossCheck = AvoidAdjPairs (result);
      if (crossCheck == "") Console.WriteLine ("\"\"");
      else foreach (char a in crossCheck) Console.Write (a);
   }

   static string AvoidAdjPairs (string input) {

      List<char> inputCharsList = new (), tempInput = input.ToList ();
      int lastRepIndex = 0, j;
      int DuplicateStringReducer (int count) {
         while (count != 0) {
            tempInput.RemoveAt (lastRepIndex);
            lastRepIndex--;
            count--;
         }
         return count;
      }
      for (int i = 0; i < tempInput.Count; i++) {
         int count = 0; char item = ' ';
         for (j = 0; j < tempInput.Count; j++) {
            if (tempInput[i] == tempInput[j]) {
               item = tempInput[j];
               lastRepIndex = j;
               count++;
            } else if (count == 1) {
               tempInput.RemoveAt (lastRepIndex);
               inputCharsList.Add (item);
               count--;
               j = -1;
            } else if (count % 2 == 0) {
               count = DuplicateStringReducer (count);
               j = -1;
            } else {
               count = DuplicateStringReducer (count);
               inputCharsList.Add (item);
               j = -1;
            }
         }
         if (count % 2 != 0) {
            count = DuplicateStringReducer (count);
            inputCharsList.Add (item);
            j = -1;
         } else if (count == 0 || count == 1) inputCharsList.Add (tempInput[i]);
         else if (count % 2 == 0) count = DuplicateStringReducer (count);
      }
      if (inputCharsList.Count == 2) if (inputCharsList[0] == inputCharsList[1]) inputCharsList.Clear ();
      return new string (inputCharsList.ToArray ());
   }
}