// Display the individual digits of a given number
internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the number");
      string input = Console.ReadLine ();
      if (!IsDecimal (input)) {
         Console.WriteLine ("Invaild input");
         return;
      }
      int dotIndex = 0;
      for (int i = 0; i < input.Length; i++) if (input[i] == '.') dotIndex = i;
      char[] integralChars = { }, factorialChars = Array.Empty<char> ();
      for (int i = 0; i < dotIndex; i++) integralChars = factorialChars.Append (input[i]).ToArray ();
      for (int i = dotIndex + 1; i < input.Length; i++) factorialChars = factorialChars.Append (input[i]).ToArray ();
      Console.WriteLine ($"Integral part of a given number is {new string (integralChars)}" +
                     $"\nFactorial part of a given number is {new string (factorialChars)}");
   }
   static bool IsDecimal (string a) {
      if (!a.Contains ('.')) return false;
      char[] isDecimal = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' };
      List<bool> isDecimalBool = new List<bool> ();
      for (int i = 0; i < a.Length; i++) {
         if (isDecimal.Contains (a[i])) isDecimalBool.Add (true);
         else isDecimalBool.Add (false);
      }
      if (isDecimalBool.Contains (false)) return false;
      else return true;
   }
}