// whether is ABECEDARIAN WORD (or) NOT
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the word to check ABECEDARIAN WORD or not");
      string input = Console.ReadLine ().ToLower ();
      var chars = input.ToCharArray ();
      var charints = new List<int> ();
      if (input.All (char.IsLetter)) {
         for (int i = 0; i < input.Length; i++) {
            int d = chars[i] - 96;
            charints.Add (d);
         }
         List<int> sortedarray = charints.GetRange (0, charints.Count);
         sortedarray.Sort ();
         bool isequal = Enumerable.SequenceEqual (charints, sortedarray);
         Console.WriteLine ($"{input} {(isequal ? "is" : "not")} an ABECEDARIAN WORD");
      } else Console.WriteLine ("Invalid Input");
   }
}