// PALINDROME CHECKER
internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the word to check palindrome (or) not");
      string a = Console.ReadLine ().ToLower (); char b; char[] c = Array.Empty<char> ();
      int i = a.Length - 1;
      while (i >= 0) {
         b = a[i];
         c = c.Append (b).ToArray ();
         i--;
      }
      var e = new string (c);
      Console.WriteLine ($"\nReverse order of {a} is {e}");
      if (string.Equals (a, e)) Console.WriteLine ("\nIs a palindrome");
      else Console.WriteLine ("\nIs not a palindrome");
   }
}