internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the word");
      string input = Console.ReadLine ().ToLower ();
      if (!input.All (char.IsLetter)) {
         Console.WriteLine ("Invaild input");
         return;
      }
      int count, inputLen = input.Length;
      List<char> inputCharList = new ();
      for (int i = 97; i <= 123; i++) {
         count = 0; int k = 0;
         for (int j = 0; j < inputLen; j++) {
            if (i == input[j]) {
               count++;
               k = j;
            }
         }
         if (count % 2 != 0) inputCharList.Add (input[k]);
      }
      if (inputCharList.Count == 0) Console.Write ("\"\""); // Display Empty string on screen
      else foreach (var a in inputCharList) Console.Write (a);
      Console.WriteLine ("\r\nDo you want to know, how many letters are repititive in your word " +
         "then press \"y\". If you don't want to known, then press any button to exit.");
      List<int> inputCharsCount = new ();
      for (int i = 0; i < inputLen; i++) {
         count = 0;
         for (int j = 0; j < inputLen; j++) {
            if (input[i] == input[j]) count++;
         }
         inputCharsCount.Add (count);
      }
      char userinput = Console.ReadKey (true).KeyChar;
      if (userinput == 'y') {
         for (int i = 97; i <= 123; i++) {
            count = 0;
            for (int j = 0; j < inputLen; j++) {
               if (input[j] == i) {
                  count++;
                  if (count == 1) Console.Write ($"{input[j]} = {inputCharsCount[j]}\r\n");
               }
            }
         }
      }
   }
}