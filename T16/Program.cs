// whether is ABECEDARIAN WORD (or) NOT
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the word to check ABECEDARIAN WORD or not");
      string input = Console.ReadLine ().ToLower ();
      List<int> chars = new (); List<bool> checkchars = new ();
      if (!input.All (char.IsLetter)) {
         Console.WriteLine ("Invalid input");
      } else {
         for (int i = 0; i < input.Length; i++) {
            int a = input[i] - 96;
            chars.Add (a);
         }
         foreach (var b in chars) { Console.WriteLine (b); }
         int count = 1; int loopcontrol = chars.Count - 1;
         for (int j = 0; j < loopcontrol; j++, count++) {
            if (j == count) {
               bool last = (chars[(chars.Count) - 1]) < (chars[(chars.Count)]);
               checkchars.Add (last);
            } else if (count < chars.Count) {
               if (chars[j] < chars[count]) checkchars.Add (true);
               else checkchars.Add (false);
            }
         }
         foreach (var a in checkchars) Console.WriteLine (a);
         if (checkchars.Contains (false)) Console.WriteLine ($"{input} not an ABECEDARIAN WORD");
         else Console.WriteLine ($"{input} is an ABECEDARIAN WORD");
      }
   }
}