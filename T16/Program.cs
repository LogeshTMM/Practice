// whether is ABECEDARIAN WORD (or) NOT
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the word to check it's an ABECEDARIAN word or not");
      string input = Console.ReadLine ().ToLower ();
      if (!input.All (char.IsLetter)) {
         Console.WriteLine ("Invalid input");
         return;
      }
      List<int> intChars = new ();
      for (int i = 0; i < input.Length; i++) {
         int a = input[i] - 96;
         intChars.Add (a);
      }
      for (int i = 0, j = 1; j < intChars.Count; i++, j++) {
         if (!(intChars[i] < intChars[j])) {
            Console.WriteLine ($"{input} not an ABECEDARIAN word");
            return;
         }
      }
      Console.WriteLine ($"{input} is an ABECEDARIAN word");
   }
}