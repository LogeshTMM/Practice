internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the word to reduce it's repeated letters");
      string input = Console.ReadLine ().ToLower ();
      if (!input.All (char.IsLetter)) {
         Console.WriteLine ("Invaild input");
         return;
      }
      List<char> inputCharsList = new (), tempInput = input.ToList ();
      for (int i = 0; i < tempInput.Count; i++) {
         int count = 0; char item = ' ';
         for (int j = 0; j < tempInput.Count; j++) {
            if (tempInput[i] == tempInput[j]) {
               count++;
               item = tempInput[j];
            }
         }
         if (count % 2 != 0) {
            inputCharsList.Add (item);
            while (count != 0) {
               tempInput.Remove (item);
               count--;
            }
            i--;
         }
      }
      if (inputCharsList.Count == 0) Console.Write ("\"\""); // Display an empty string on the screen.
      else foreach (var a in inputCharsList) Console.Write (a);
   }
}