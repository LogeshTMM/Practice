// REDUCE REPATED STRING
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the word to reduce it's repeated letters");
      string input = Console.ReadLine ();
      if (!input.All (char.IsLetter) | input == "") {
         Console.WriteLine ("Invaild input");
         return;
      }
      string result = AvoidAdjPairs (input);
      while (true) {
         List<int> ints = new ();
         for (int i = 0, count = 0; i < result.Length; i++) {
            for (int j = 0; j < result.Length; j++) if (result[i] == result[j]) count++;
            ints.Add (count);
            count = 0;
         }
         if (ints.Sum () == result.Length) {
            if (result == "") Console.WriteLine ("\"\"");
            Console.Write (result);
            return;
         }
         int counting = 0;
         for (int i = 0, j = 1; i < result.Length - 1; i++, j++) if (result[i] == result[j]) counting++;
         if (counting >= 1) result = AvoidAdjPairs (result);
         else {
            Console.Write (result);
            return;
         }
      }
   }

   static string AvoidAdjPairs (string input) {
      List<char> inputCharsList = new (), tempInput = input.ToList ();
      int lastRepIndex = 0, j;
      for (int i = 0; i < tempInput.Count; i++) {
         int count = 0; char item = ' ';
         for (j = 0; j < tempInput.Count; j++) {
            if (tempInput[i] == tempInput[j]) {
               /* Gather successive characters as the same as tempInput[i]. For example, Says that the string value is abdccdb, 
                  then the count values for each char in the string as follows a -> 1, b -> 2, d -> 2, c -> 2 */
               item = tempInput[j];
               lastRepIndex = j;
               count++;
            } else if (count == 1) {
               // If the successive character count is 1, add to the list output (inputCharsList) and remove from the input (tempInput).
               tempInput.RemoveAt (lastRepIndex);
               inputCharsList.Add (item);
               count--;
               j = -1;
            } else if (count % 2 == 0) {
               // If we gathered even number of characters, remove it from the output (inputCharsList).
               count = DuplicateStringReducer (count);
               j = -1;
            } else { // If we gathered odd number of characters other than 1, add to the output (inputCharsList) and remove from the input (tempInput).
               count = DuplicateStringReducer (count);
               inputCharsList.Add (item);
               j = -1;
            }
         }
         if (count % 2 != 0) { // If we gathered odd number of characters add to the output (inputCharsList) and remove from the input (tempInput).
            DuplicateStringReducer (count);
            inputCharsList.Add (item);
         } else if (count == 0 || count == 1) inputCharsList.Add (tempInput[i]);
         // If we gathered the number of character is 0 (or) 1, add to the output (inputCharsList).
         else if (count % 2 == 0) DuplicateStringReducer (count);
         // If we gathered even number of characters, remove it from the input (tempInput). By using DuplicateStringReducer method.
      }
      if (inputCharsList.Count == 2) if (inputCharsList[0] == inputCharsList[1]) inputCharsList.Clear ();
      return new string (inputCharsList.ToArray ());

      int DuplicateStringReducer (int count) {
         while (count != 0) {
            tempInput.RemoveAt (lastRepIndex);
            lastRepIndex--;
            count--;
         }
         return count;
      }
   }
}