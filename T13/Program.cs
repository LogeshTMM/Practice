// Whether is a strong (or) password
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the Password to check whether it's strong (or) weak");
      string pw = Console.ReadLine ();
      List<bool> special_char = new ();
      foreach (char c in pw) special_char.Add (char.IsLetterOrDigit (c));
      bool d = pw.Any (char.IsDigit);
      bool u = pw.Any (char.IsUpper);
      bool l = pw.Any (char.IsLower);
      bool s = special_char.Contains (false);
      bool pw_len = pw.Length > 6;
      if (d && u && l && s && pw_len) Console.WriteLine ("Strong Password, you have.");
      else {
         Console.Write ("\nYou have a weak Password, reason is given below\n");
         if (!pw_len) Console.WriteLine ("* Length of a password should be more than 6");
         if (!d) Console.WriteLine ("* It contains at least one digit.");
         if (!u) Console.WriteLine ("* It contains at least one upper character.");
         if (!l) Console.WriteLine ("* It contains at least one lower character.");
         if (!s) Console.WriteLine ("* It contains at least one special character.");
         Console.WriteLine ("Try again for a strong password");
      }
   }
}