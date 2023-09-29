// whether is ABECEDARIAN WORD (or) NOT
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the word to check it's an ABECEDARIAN word or not");
      string input = Console.ReadLine ().ToLower ();
      List<int> intChars = new (); List<bool> boolIntChars = new ();
      if (!input.All (char.IsLetter)) {
         Console.WriteLine ("Invalid input");
      } else {
         for (int i = 0; i < input.Length; i++) {
            int a = input[i] - 96;
            intChars.Add (a);
         }
         for (int i = 0, j = 1; j < intChars.Count; i++, j++) {
            if (intChars[i] < intChars[j]) {
               boolIntChars.Add (true);
            } else {
               boolIntChars.Add (false);
               Console.WriteLine ($"{input} not an ABECEDARIAN word");
               return;
            }
         }
         if (!boolIntChars.Contains (false)) Console.WriteLine ($"{input} is an ABECEDARIAN word");
      }
   }
}