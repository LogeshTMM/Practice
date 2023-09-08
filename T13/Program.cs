// Whether is a strong (or) password
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the Password to check whether it's strong (or) weak");
      string Pw = Console.ReadLine (); var digit = new List<bool> (); var upper = new List<bool> ();
      var lower = new List<bool> (); var special = new List<bool> (); int n_len = Pw.Length;
      foreach (char b in Pw) digit.Add (char.IsDigit (b));
      foreach (char c in Pw) upper.Add (char.IsUpper (c));
      foreach (char c in Pw) lower.Add (char.IsLower (c));
      foreach (char c in Pw) special.Add (char.IsLetterOrDigit (c));
      bool d = digit.Contains (true);
      bool u = upper.Contains (true);
      bool l = lower.Contains (true);
      bool s = special.Contains (false);
      bool n = n_len > 6;
      if (d && u && l && s && n == true) Console.WriteLine ("Strong Password, you have.");
      else {
         Console.Write ("\nYou have a weak Password, reason is given below\n");
         if (n_len < 6) Console.WriteLine ("\t* Length of a password should be more than 6");
         if (d == false) Console.WriteLine ("\t* It contains at least one digit.");
         if (u == false) Console.WriteLine ("\t* It contains at least one upper character.");
         if (l == false) Console.WriteLine ("\t* It contains at least one lower character.");
         if (s == false) Console.WriteLine ("\t* It contains at least one special character.");
         Console.WriteLine ("Try again for a strong Password");
      }
   }
}