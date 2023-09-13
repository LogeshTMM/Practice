// Whether is a strong (or) password
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the Password to check whether it's strong (or) weak");
      string pw = Console.ReadLine (), special = "!@#$%^&*()_+/";
      bool asDigit, asUpper, asLower, hasSpecial;
      asDigit = asUpper = asLower = hasSpecial = false;
      for (int i = 0; i < pw.Length; i++) {
         if (pw.Any (char.IsDigit)) {
            asDigit = true;
            break;
         }
      }
      for (int i = 0; i < pw.Length; i++) {
         if (pw.Any (char.IsUpper)) {
            asUpper = true;
            break;
         }
      }
      for (int i = 0; i < pw.Length; i++) {
         if (pw.Any (char.IsLower)) {
            asLower = true;
            break;
         }
      }
      for (int i = 0; i < pw.Length; i++) {
         if (special.Contains (pw[i])) {
            hasSpecial = true;
            break;
         }
      }
      bool pw_len = pw.Length > 6;
      if (asDigit && asUpper && asLower && hasSpecial && pw_len) Console.WriteLine ("Strong Password, you have.");
      else {
         Console.Write ("You have a weak Password, reason is given below:\r\n");
         if (!pw_len) Console.WriteLine ("   " + "* Length of a password should be more than 6");
         if (!asDigit) Console.WriteLine ("   " + "* It contains at least one digit.");
         if (!asUpper) Console.WriteLine ("   " + "* It contains at least one upper character.");
         if (!asLower) Console.WriteLine ("   " + "* It contains at least one lower character.");
         if (!hasSpecial) Console.WriteLine ("   " + "* It contains at least one special character.");
         Console.WriteLine ("Try again for a strong password.");
      }
   }
}