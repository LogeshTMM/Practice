// PALINDROME CHECKER
internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the word to check palindrome (or) not");
      string a = Console.ReadLine (); var b = a.Reverse ().ToArray ();
      var c = new string (b);       /*Console.Write(b.GetType ());*/
      Console.WriteLine ($"Reverse order of {a} is {c}");
      if (string.Equals (a, c)) Console.WriteLine ("Is a palindrome");
      else Console.WriteLine ("Is not a palindrome");
   }
}