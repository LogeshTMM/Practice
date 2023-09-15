// whether is ABECEDARIAN WORD (or) NOT
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the word to check ABECEDARIAN WORD or not");
      string input = Console.ReadLine ().ToLower ();
      var chars = input.ToCharArray ();
      if (!input.All (char.IsLetter)) {
         Console.WriteLine ("Invalid input");
      } else {
         var sortedchars = chars.Order ();
         bool isequal = Enumerable.SequenceEqual (chars, sortedchars);
         Console.WriteLine ($"{input} {(isequal ? "is" : "not")} an ABECEDARIAN WORD");
      }
   }
}