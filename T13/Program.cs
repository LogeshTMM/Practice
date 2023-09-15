// Whether is a strong (or) password
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the Password to check whether it's strong (or) weak");
      string pw = Console.ReadLine (), special = "!@#$%^&*()_+/";
      bool hasDigit = false, hasUpper = false, hasLower = false, hasSpecial = false;
      bool pw_len = pw.Length > 6;
      for (int i = 0; i < pw.Length; i++) {
         if (char.IsDigit (pw[i])) hasDigit = true;
         if (char.IsUpper (pw[i])) hasUpper = true;
         if (char.IsLower (pw[i])) hasLower = true;
         if (special.Contains (pw[i])) hasSpecial = true;
         if (hasDigit && hasUpper && hasLower && hasSpecial) break;
      }
      if (pw_len && hasDigit && hasUpper && hasLower && hasSpecial) Console.WriteLine ("Strong Password, you have.");
      else {
         Console.Write ("You have a weak Password, reason is given below:\r\n");
         if (!pw_len) Console.WriteLine ("   " + "* Length of a password should be more than 6");
         if (!hasDigit) Console.WriteLine ("   " + "* It contains at least one digit.");
         if (!hasUpper) Console.WriteLine ("   " + "* It contains at least one upper character.");
         if (!hasLower) Console.WriteLine ("   " + "* It contains at least one lower character.");
         if (!hasSpecial) Console.WriteLine ("   " + "* It contains at least one special characters"
                                             + " like (!,@,#,$,%,^,&,*,(,),_,+,/).");
         Console.WriteLine ("Try again for a strong password.");
      }
   }
}