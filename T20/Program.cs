// Display the individual digits of a given number
internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the decimal number to display it's integral and factorial part");
      string input = Console.ReadLine ();
      if (!IsDecimal (input)) {
         Console.WriteLine ("Invaild input");
         return;
      }
      int dotIndex = 0, i = 0;
      while (i < input.Length) {
         if (input[i] == '.') {
            dotIndex = i;
            break;
         }
         i++;
      }
      char[] integralChars = Array.Empty<char> (), factorialChars = Array.Empty<char> ();
      for (int j = 0; j < dotIndex; j++) integralChars = integralChars.Append (input[j]).ToArray ();
      for (int j = dotIndex + 1; j < input.Length; j++) factorialChars = factorialChars.Append (input[j]).ToArray ();
      Console.WriteLine ($"Integral part of a given number is {new string (integralChars)}" +
                     $"\nFactorial part of a given number is {new string (factorialChars)}");
   }
   static bool IsDecimal (string a) {
      if (!a.Contains ('.')) return false;
      char[] isDecimal = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' };
      List<bool> isDecimalBool = new List<bool> ();
      for (int i = 0, count = 0; i < a.Length; i++) {
         if (isDecimal.Contains (a[i])) isDecimalBool.Add (true);
         else isDecimalBool.Add (false);
         if (a[i] == '.') {
            count++;
            if (count == 2) return false;
         }
      }
      if (isDecimalBool.Contains (false)) return false;
      else return true;
   }
}