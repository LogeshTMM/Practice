// REDUCE REPATED STRING
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the word to reduce it's repeated letters");
      string input = Console.ReadLine ();
      if (!input.All (char.IsLetter)) {
         Console.WriteLine ("Invaild input");
         return;
      }
      string result = AvoidAdjPairs (input);
      if (result == "") Console.WriteLine ("\"\"");
      else foreach (char a in result) Console.Write (a);
   }

   static string AvoidAdjPairs (string input) {
      List<char> inputCharsList = new (), tempInput = input.ToList ();
      int lastRepIndex = 0, j;
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
               while (count != 0) {
                  tempInput.RemoveAt (lastRepIndex);
                  lastRepIndex--;
                  count--;
               }
               j = -1;
            } else {
               while (count != 0) {
                  tempInput.RemoveAt (lastRepIndex);
                  lastRepIndex--;
                  count--;
               }
               inputCharsList.Add (item);
               j = -1;
            }
         }
         if (count % 2 != 0) {
            while (count != 0) {
               tempInput.RemoveAt (lastRepIndex);
               lastRepIndex--;
               count--;
            }
            inputCharsList.Add (item);
            j = -1;
         } else if (count == 0 || count == 1) inputCharsList.Add (tempInput[i]);
         else if (count % 2 == 0) {
            while (count != 0) {
               tempInput.RemoveAt (lastRepIndex);
               lastRepIndex--;
               count--;
            }
         }
      }
      if (inputCharsList.Count == 2) if (inputCharsList[0] == inputCharsList[1]) inputCharsList.Clear ();
      return new string (inputCharsList.ToArray ());
   }
}