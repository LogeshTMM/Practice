internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the word");
      string input = Console.ReadLine ().ToLower ();
      if (!input.All (char.IsLetter)) {
         Console.WriteLine ("Invaild input");
         return;
      }
      int count, len = input.Length;
      List<char> order_charlist = new (); List<int> chars_count = new ();
      for (int i = 0; i < len; i++) {
         count = 0;
         for (int j = 0; j < len; j++) {
            if (input[i] == input[j]) count++;
         }
         chars_count.Add (count);
      }
      for (int i = 97; i <= 123; i++) {
         count = 0;
         for (int j = 0; j < len; j++) {
            if (input[j] == i) {
               count++;
               if (count == 1) order_charlist.Add (input[j]);
            }
         }
      }
      foreach (var a in order_charlist) Console.Write (a);
      Console.WriteLine ("\r\nDo you want to know, how many letters repititive in your word." + " " +
         "Then press \"y\" (or) don't want to known, then press \"n\"");
      char userinput = Console.ReadKey (true).KeyChar;
      if (userinput == 'y') {
         for (int i = 97; i <= 123; i++) {
            count = 0;
            for (int j = 0; j < len; j++) {
               if (input[j] == i) {
                  count++;
                  if (count == 1) Console.Write ($"{input[j]} = {chars_count[j]}\r\n");
               }
            }
         }
      }
   }
}