// REVERSE A GIVEN NUMBER
internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the number to get the reverse order");
      long.TryParse (Console.ReadLine (), out long n);
      if (n == 0) Console.WriteLine ("Invaild Input");
      var org_n = n.ToString (); var dup = Array.Empty<char> (); char dummy;
      if (n != 0) {
         Console.Write ("Reverse order of given number is" + " ");
         for (int i = org_n.Length; i != 0; i--) {
            Console.Write (org_n[i - 1]);
            dummy = org_n[i - 1];
            dup = dup.Append (dummy).ToArray ();
         }
         string dup_n = new string (dup);
         if (string.Equals (org_n, dup_n)) Console.Write ("\nIt's a palindrome");
         else Console.Write ("\nIt's not a palindrome");
      }
   }
}