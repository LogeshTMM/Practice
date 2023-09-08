// GIVEN NUMBER TO WORD FORMAT AND ROMAN NUMERALS CONVERTER
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the number to convert digits");
      int.TryParse (Console.ReadLine (), out int num);
      var n = num.ToString ();
      int n_len = n.Length;
      if (num == 0) Console.WriteLine ("Invaild Input");
      else if (n_len != 0 && n_len <= 5) {
         /* string n = Console.ReadLine ();*/
         char[] j = { }; char m;
         Console.WriteLine ($"\nThe length of a given digit is {n_len}");
         Console.WriteLine ("\nIf you want to convert numbers to word format, then press 'w'\nIf you want to convert numbers to roman numerals, then press 'r'\n" +
            "If you want to convert numbers to both word format and roman numerals, then press 'b'");
         var user_respond_key = Console.ReadKey (true).KeyChar;
         string[] ones = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
         string[] tens = { "ten", "eleven", "tweleve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
         string[] tens_2 = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
         string[] thousand = { "hundred", "thousand" };
         string[] roman_ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" }; //ones
         string[] roman_tens = { "X", "XI", "XII", "XIII", "XIV", "XV", "XVI", "XVII", "XVIII", "XIX" };// ten to nineteen
         string[] roman_tens_2 = { "", "", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" }; // twenty to ninety
         string[] roman_hundred = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" }; // hundred
         string[] roman_thousand = { "", "M", "MM", "MMM", "MMMM", "^V", "^VM", "^VMM", "^VMMM", "MX^" }; // thousand
         string[] roman_ten_thousand = { "^X" }; // ten thousand
         if (user_respond_key == 'w' || user_respond_key == 'b') {
            Console.Write ($"\nThe Word format for a given number is ");
            if (n_len == 5) {
               for (int i = 1; i <= n_len; i++) {
                  m = n[i - 1];
                  j = j.Append (m).ToArray ();
               }
               int t1 = Convert.ToChar (j[0] - 48); int t2 = Convert.ToChar (j[1] - 48); int t3 = Convert.ToChar (j[2] - 48);
               int t4 = Convert.ToChar (j[3] - 48); int t5 = Convert.ToChar (j[4] - 48);
               //Console.WriteLine (t2);
               //THOUSAND RANGE
               if (t1 > 1 && t2 == 0) Console.Write ($"{tens_2[t1].ToUpper ()} {thousand[1].ToUpper ()}");
               else if (t1 == 1 && t2 == 0) Console.Write ($"{tens[t1 - 1].ToUpper ()} {thousand[1].ToUpper ()}");
               else if (t1 == 1 && t2 != 0) Console.Write ($"{tens[t1].ToUpper ()} {thousand[1].ToUpper ()}");
               else if (t1 != 1 && t2 != 0) Console.Write ($"{tens_2[t1].ToUpper ()} {ones[t2].ToUpper ()} {thousand[1].ToUpper ()}");
               // HUNDRED RANGE
               if (t3 >= 1) Console.Write ($" {ones[t3].ToUpper ()} {thousand[0].ToUpper ()}");
               // TENS RANGE
               if (t4 == 1 && t5 == 0) Console.Write ($" {tens[t4 - 1].ToUpper ()}");
               else if (t4 == 1 && t5 != 0) Console.Write ($" {tens[t4].ToUpper ()}");
               else if (t4 > 1 && t5 == 0) Console.Write ($" {tens_2[t4].ToUpper ()} {ones[t5].ToUpper ()}");
               else if (t4 > 1 && t5 != 0) Console.Write ($" {tens_2[t4].ToUpper ()} {ones[t5].ToUpper ()}");
               // ONES RANGE
               if (t1 == 0 && t2 == 0 && t3 == 0 && t4 == 0 && t5 != 0) Console.Write ($"{ones[t5].ToUpper ()}");
               else if (t4 == 0 && t5 != 0) Console.Write ($" and {ones[t5].ToUpper ()}");
            }
            if (n_len == 4) {
               for (int i = 1; i <= n_len; i++) {
                  m = n[i - 1];
                  j = j.Append (m).ToArray ();
               }
               int t1 = Convert.ToChar (j[0] - 48); int t2 = Convert.ToChar (j[1] - 48); int t3 = Convert.ToChar (j[2] - 48); int t4 = Convert.ToChar (j[3] - 48);
               //
               if (t1 >= 1 && t2 >= 0) Console.Write ($"{ones[t1].ToUpper ()} {thousand[1].ToUpper ()}");
               //
               if (t2 >= 1 /*&& t3 >= 0*/) Console.Write ($" {ones[t2].ToUpper ()} {thousand[0].ToUpper ()}");
               //
               if (t3 == 1 && t4 == 0) Console.Write ($" {tens[t3 - 1].ToUpper ()}");
               else if (t3 == 1 && t4 >= 0) Console.Write ($" {tens[t3].ToUpper ()}");
               else if (t3 > 1 && t4 >= 0) Console.Write ($" {tens_2[t3].ToUpper ()}");
               //
               if (t1 == 0 && t2 == 0 && t3 == 0 && t4 >= 1) Console.Write ($"{ones[t4].ToUpper ()}");
               else if (t3 == 0 && t4 >= 1) Console.Write ($" and {ones[t4].ToUpper ()}");
            }
            if (n_len == 3) {
               for (int i = 1; i <= n_len; i++) {
                  m = n[i - 1];
                  j = j.Append (m).ToArray ();
               }
               int t1 = Convert.ToChar (j[0] - 48); int t2 = Convert.ToChar (j[1] - 48); int t3 = Convert.ToChar (j[2] - 48);
               //
               if (t1 >= 1 && t2 >= 0) Console.Write ($"{ones[t1].ToUpper ()} {thousand[0].ToUpper ()}");
               //
               if (t2 == 1 && t3 == 0) Console.Write ($" {tens[t2 - 1].ToUpper ()}");
               else if (t2 == 1 && t3 >= 1) Console.Write ($" {tens[t2].ToUpper ()}");
               else if (t2 > 1 && t3 >= 0) Console.Write ($" {tens_2[t2].ToUpper ()} {ones[t3].ToUpper ()}");
               //
               if (t1 == 0 && t2 == 0 && t3 >= 1) Console.Write ($" {ones[t3].ToUpper ()}");
               else if (t2 == 0 && t3 >= 1) Console.Write ($" and {ones[t3].ToUpper ()}");
            }
            if (n_len == 2) {
               for (int i = 1; i <= n_len; i++) {
                  m = n[i - 1];
                  j = j.Append (m).ToArray ();
               }
               int t1 = Convert.ToChar (j[0] - 48); int t2 = Convert.ToChar (j[1] - 48);
               //
               if (t1 == 1 && t2 == 0) Console.Write ($"{tens[t1 - 1].ToUpper ()}");
               else if (t1 == 1 && t2 >= 1) Console.Write ($"{tens[t2].ToUpper ()}");
               else if (t1 > 1 && t2 >= 1) Console.Write ($"{tens_2[t1].ToUpper ()} {ones[t2].ToUpper ()}");
               //
               if (t1 == 0 && t2 != 0) Console.Write ($"{ones[t2]}");
            }
            if (n_len == 1) {
               int t1 = Convert.ToChar (n[0] - 48);
               if (t1 == 0) Console.Write ("Zero");
               else if (t1 >= 1 && t1 <= 9) Console.Write ($"{ones[t1].ToUpper ()}");
            }
         }
         if (user_respond_key == 'r' || user_respond_key == 'b') {
            if (n_len == 1 || n_len <= 5) {
               Console.Write ($"\nThe Roman numerals format for a given number is ");
               if (n_len == 5) {
                  for (int i = 1; i <= n_len; i++) {
                     m = n[i - 1];
                     j = j.Append (m).ToArray ();
                  }
                  int t1 = Convert.ToChar (j[0] - 48); int t2 = Convert.ToChar (j[1] - 48); int t3 = Convert.ToChar (j[2] - 48);
                  int t4 = Convert.ToChar (j[3] - 48); int t5 = Convert.ToChar (j[4] - 48);
                  //
                  if (t1 == 1 && t2 == 0) Console.Write ($"{roman_ten_thousand[0]}");
                  //
                  if (t2 == 0 && t3 >= 1) Console.Write ($"{roman_hundred[t3]}");
                  //
                  if (t2 == 0 && t3 >= 1 && t4 > 1 && t5 != 0) Console.Write ($"{roman_tens_2[t4]}{roman_ones[t5]}");
                  else if (t2 == 0 && t3 == 0 && t4 > 1 && t5 == 0) Console.Write ($"{roman_tens_2[t4]}");
                  else if (t2 == 0 && t3 == 0 && t4 > 1 && t5 != 0) Console.Write ($"{roman_tens_2[t4]}{roman_ones[t5]}");
                  else if (t2 == 0 && t3 == 0 && t4 == 1 && t5 == 0) Console.Write ($"{roman_tens[t4 - 1]}");
                  else if (t2 == 0 && t3 == 0 && t4 == 1 && t5 != 0) Console.Write ($"{roman_tens[t4]}");
                  //
                  if (t3 == 0 && t4 == 0 && t5 >= 1) Console.Write ($"{roman_ones[t5]}");
                  else if (t3 != 0 && t4 == 0 && t5 >= 1) Console.Write ($"{roman_ones[t5]}");
                  else if (t1 == 0 && t2 == 0 && t3 == 0 && t4 == 0 && t5 >= 1) Console.Write ($"{roman_ones[t5]}");
                  Console.WriteLine ("\n\nNote: In Roman numerals the symbol '^' is not valid due to IDE constrain it has to do, kindly refer to the internet.");
               }
               if (n_len == 4) {
                  for (int i = 1; i <= n_len; i++) {
                     m = n[i - 1];
                     j = j.Append (m).ToArray ();
                  }
                  int t1 = Convert.ToChar (j[0] - 48); int t2 = Convert.ToChar (j[1] - 48); int t3 = Convert.ToChar (j[2] - 48); int t4 = Convert.ToChar (j[3] - 48);
                  //
                  if (t1 >= 1 && t2 >= 0) Console.Write ($"{roman_thousand[t1]}");
                  //
                  if (t2 >= 1 && t3 >= 0) Console.Write ($"{roman_hundred[t2]}");
                  //
                  if (t3 >= 1 && t4 == 0) Console.Write ($"{roman_tens[t3 - 1]}");
                  else if (t3 > 1 && t4 >= 1) Console.Write ($"{roman_tens_2[t3]}{roman_ones[t4]}");
                  //
                  if (t2 == 0 && t3 == 0 && t4 != 0) Console.Write ($"{roman_ones[t4]}");
                  else if (t2 != 0 && t3 == 0 && t4 != 0) Console.Write ($"{roman_ones[t4]}");
                  else if (t1 == 0 && t2 == 0 && t3 == 0 && t4 != 0) Console.Write ($"{roman_ones[t4]}");
                  Console.WriteLine ("\n\nNote: In Roman numerals the symbol '^' is not valid due to IDE constrain it has to do, kindly refer to the internet.");
               }
               if (n_len == 3) {
                  for (int i = 1; i <= n_len; i++) {
                     m = n[i - 1];
                     j = j.Append (m).ToArray ();
                  }
                  int t1 = Convert.ToChar (j[0] - 48); int t2 = Convert.ToChar (j[1] - 48); int t3 = Convert.ToChar (j[2] - 48);
                  //
                  if (t1 != 0) Console.Write ($"{roman_hundred[t1]}");
                  //
                  if (t2 == 1 && t3 == 0) Console.Write ($"{roman_tens[t2 - 1]}");
                  else if (t2 == 1 && t3 >= 1) Console.Write ($"{roman_tens_2[t2]}");
                  else if (t2 > 1 && t3 >= 1) Console.Write ($"{roman_tens_2[t2]}{roman_ones[t3]}");
                  //
                  if (t1 == 0 && t2 == 0 && t3 != 0) Console.Write ($"{roman_ones[t3]}");
                  else if (t2 == 0 && t3 != 0) Console.Write ($"{roman_ones[t3]}");
               }
               if (n_len == 2) {
                  for (int i = 1; i <= n_len; i++) {
                     m = n[i - 1];
                     j = j.Append (m).ToArray ();
                  }
                  int t1 = Convert.ToChar (j[0] - 48); int t2 = Convert.ToChar (j[1] - 48);
                  //
                  if (t1 == 1 && t2 == 0) Console.Write ($"{roman_tens[t1 - 1]}");
                  else if (t1 == 1 && t2 >= 1) Console.Write ($"{roman_tens[t2]}");
                  else if (t1 > 1 && t2 >= 1) Console.Write ($"{roman_tens_2[t1]}{roman_ones[t2]}");
                  //
                  if (t1 == 0 && t2 != 0) Console.Write ($"{roman_ones[t2]}");
               }
               if (n_len == 1) {
                  int t1 = Convert.ToChar (n[0] - 48);
                  if (t1 != 0) Console.Write ($"{roman_ones[t1]}");
                  else Console.Write ("none"); // There is no symbol for zero in Roman numerals 
               }
            }
         } else Console.WriteLine ("\nYou press wrong button, try again");
      } else Console.Write ("The length of a given digit is out of range,type less than 5 digits to get an output\n");
   }
}