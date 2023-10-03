// CONVERT THE GIVEN NUMBER INTO WORD FORMAT AND ROMAN NUMERALS FORMAT
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the number to convert into \"Words\" and \"Roman numerals\"");
      if (!int.TryParse (Console.ReadLine (), out int num)) {
         Console.WriteLine ("Invaild input");
         return;
      }
      var numString = num.ToString ();
      int numLen = numString.Length;
      if (numLen != 0 && numLen <= 5) {
         Console.WriteLine ($"\nThe length of a given digit is {numLen}");
         Console.WriteLine ("\nIf you want to convert numbers to word format, then press 'w'" +
            "\nIf you want to convert numbers to roman numerals, then press 'r'\n" +
            "If you want to convert numbers to both word format and roman numerals, then press 'b'");
         var userRespondKey = Console.ReadKey (true).KeyChar;
         char[] vaildKey = { 'w', 'r', 'b' };
         if (!vaildKey.Contains (userRespondKey)) {
            Console.WriteLine ("\nYou press the wrong button, try again");
            return;
         }
         string[] ones = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
         string[] tens = { "ten", "eleven", "tweleve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
         string[] tens_2 = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
         string[] thousand = { "hundred", "thousand" };
         string[] roman_ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" }; //ones
         string[] roman_tens = { "X", "XI", "XII", "XIII", "XIV", "XV", "XVI", "XVII", "XVIII", "XIX" };// ten to nineteen
         string[] roman_tens_2 = { "", "", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" }; // twenty to ninety
         string[] roman_hundred = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" }; // hundred
         string[] roman_thousand = { "", "M", "MM", "MMM", "MMMM", "^V", "^VM", "^VMM", "^VMMM", "MX^" }; // one to nine thousand
         string[] roman_ten_thousand = { "", "^X", "^XX", "^XXX", "^XL", "^L", "^LX", "^LXX", "^LXXX", "^XC" }; // ten to ninety thousand
         if (userRespondKey == 'w' || userRespondKey == 'b') {
            Console.Write ($"\nThe Word format for a given number is ");
            if (numLen == 5) {
               int t1 = Convert.ToChar (numString[0] - 48); int t2 = Convert.ToChar (numString[1] - 48); int t3 = Convert.ToChar (numString[2] - 48);
               int t4 = Convert.ToChar (numString[3] - 48); int t5 = Convert.ToChar (numString[4] - 48);
               //THOUSAND RANGE
               if (t1 > 1 && t2 == 0) Console.Write ($"{tens_2[t1].ToUpper ()} {thousand[1].ToUpper ()}");
               else if (t1 == 1 && t2 == 0) Console.Write ($"{tens[t1 - 1].ToUpper ()} {thousand[1].ToUpper ()}");
               else if (t1 == 1 && t2 != 0) Console.Write ($"{tens[t1].ToUpper ()} {thousand[1].ToUpper ()}");
               else if (t1 != 1 && t2 != 0) Console.Write ($"{tens_2[t1].ToUpper ()} {ones[t2].ToUpper ()} {thousand[1].ToUpper ()}");
               // HUNDRED RANGE
               if (t3 >= 1) Console.Write ($" {ones[t3].ToUpper ()} {thousand[0].ToUpper ()}");
               // TENS RANGE
               if (t4 == 1 && t5 == 0) Console.Write ($" {tens[t4 - 1].ToUpper ()}");
               else if (t4 == 1 && t5 != 0) Console.Write ($" {tens[t5].ToUpper ()}");
               else if (t4 > 1 && t5 == 0) Console.Write ($" {tens_2[t4].ToUpper ()} {ones[t5].ToUpper ()}");
               else if (t4 > 1 && t5 != 0) Console.Write ($" {tens_2[t4].ToUpper ()} {ones[t5].ToUpper ()}");
               // ONES RANGE
               if (t1 == 0 && t2 == 0 && t3 == 0 && t4 == 0 && t5 != 0) Console.Write ($"{ones[t5].ToUpper ()}");
               else if (t4 == 0 && t5 != 0) Console.Write ($" and {ones[t5].ToUpper ()}");
            } else if (numLen == 4) {
               int t1 = Convert.ToChar (numString[0] - 48); int t2 = Convert.ToChar (numString[1] - 48);
               int t3 = Convert.ToChar (numString[2] - 48); int t4 = Convert.ToChar (numString[3] - 48);
               //
               if (t1 >= 1 && t2 >= 0) Console.Write ($"{ones[t1].ToUpper ()} {thousand[1].ToUpper ()}");
               //
               if (t2 >= 1) Console.Write ($" {ones[t2].ToUpper ()} {thousand[0].ToUpper ()}");
               //
               if (t3 == 1 && t4 == 0) Console.Write ($" {tens[t3 - 1].ToUpper ()}");
               else if (t3 == 1 && t4 >= 1) Console.Write ($" {tens[t4].ToUpper ()}");
               else if (t3 > 1 && t4 >= 0) Console.Write ($" {tens_2[t3].ToUpper ()}");
               //
               if (t1 == 0 && t2 == 0 && t3 == 0 && t4 >= 1) Console.Write ($"{ones[t4].ToUpper ()}");
               else if (t3 == 0 && t4 >= 1) Console.Write ($" and {ones[t4].ToUpper ()}");
            } else if (numLen == 3) {
               int t1 = Convert.ToChar (numString[0] - 48); int t2 = Convert.ToChar (numString[1] - 48); int t3 = Convert.ToChar (numString[2] - 48);
               //
               if (t1 >= 1 && t2 >= 0) Console.Write ($"{ones[t1].ToUpper ()} {thousand[0].ToUpper ()}");
               //
               if (t2 == 1 && t3 == 0) Console.Write ($" {tens[t2 - 1].ToUpper ()}");
               else if (t2 == 1 && t3 >= 1) Console.Write ($" {tens[t3].ToUpper ()}");
               else if (t2 > 1 && t3 >= 0) Console.Write ($" {tens_2[t2].ToUpper ()} {ones[t3].ToUpper ()}");
               //
               if (t1 == 0 && t2 == 0 && t3 >= 1) Console.Write ($" {ones[t3].ToUpper ()}");
               else if (t2 == 0 && t3 >= 1) Console.Write ($" and {ones[t3].ToUpper ()}");
            } else if (numLen == 2) {
               int t1 = Convert.ToChar (numString[0] - 48); int t2 = Convert.ToChar (numString[1] - 48);
               //
               if (t1 == 1 && t2 == 0) Console.Write ($"{tens[t1 - 1].ToUpper ()}");
               else if (t1 == 1 && t2 >= 1) Console.Write ($"{tens[t2].ToUpper ()}");
               else if (t1 > 1 && t2 == 0) Console.WriteLine ($"{tens_2[t1]}");
               else if (t1 > 1 && t2 >= 1) Console.Write ($"{tens_2[t1].ToUpper ()} {ones[t2].ToUpper ()}");
               //
               if (t1 == 0 && t2 != 0) Console.Write ($"{ones[t2]}");
            } else if (numLen == 1) {
               int t1 = Convert.ToChar (numString[0] - 48);
               if (t1 == 0) Console.Write ("Zero");
               else if (t1 >= 1 && t1 <= 9) Console.Write ($"{ones[t1].ToUpper ()}");
            }
         }
         if (userRespondKey == 'r' || userRespondKey == 'b') {
            Console.Write ($"\nThe Roman numerals format for a given number is ");
            if (numLen == 5) {
               int t1 = Convert.ToChar (numString[0] - 48); int t2 = Convert.ToChar (numString[1] - 48);
               int t3 = Convert.ToChar (numString[2] - 48); int t4 = Convert.ToChar (numString[3] - 48);
               int t5 = Convert.ToChar (numString[4] - 48);
               //
               if (t1 >= 1 && t2 == 0) Console.Write ($"{roman_ten_thousand[t1]}");
               if (t1 >= 1 && t2 >= 1 && t3 >= 1 && t4 == 1 && t5 >= 0) Console.Write ($"{roman_ten_thousand[t1]}{roman_ones[t2]}{roman_hundred[t3]}{roman_tens[t5]}");
               if (t1 >= 1 && t2 >= 1 && t3 >= 1 && t4 > 1 && t5 >= 1) Console.Write ($"{roman_ten_thousand[t1]}{roman_ones[t2]}{roman_hundred[t3]}{roman_tens_2[t4]}{roman_ones[t5]}");
               //
               if (t2 == 0 && t3 >= 1 && t4 > 1 && t5 != 0) Console.Write ($"{roman_tens_2[t4]}{roman_ones[t5]}");
               else if (t2 == 0 && t3 == 0 && t4 > 1 && t5 == 0) Console.Write ($"{roman_tens_2[t4]}");
               else if (t2 == 0 && t3 == 0 && t4 > 1 && t5 != 0) Console.Write ($"{roman_tens_2[t4]}{roman_ones[t5]}");
               else if (t2 == 0 && t3 == 0 && t4 == 1 && t5 == 0) Console.Write ($"{roman_tens[t4 - 1]}");
               else if (t2 == 0 && t3 == 0 && t4 == 1 && t5 != 0) Console.Write ($"{roman_tens[t5]}");
               //
               if (t3 == 0 && t4 == 0 && t5 >= 1) Console.Write ($"{roman_ones[t5]}");
               else if (t3 != 0 && t4 == 0 && t5 >= 1) Console.Write ($"{roman_ones[t5]}");
               else if (t1 == 0 && t2 == 0 && t3 == 0 && t4 == 0 && t5 >= 1) Console.Write ($"{roman_ones[t5]}");
               Console.WriteLine ("\n\nNote: In Roman numerals the symbol '^' is not valid " +
                  "due to IDE constrain it has to do, kindly refer internet.");
            } else if (numLen == 4) {
               int t1 = Convert.ToChar (numString[0] - 48); int t2 = Convert.ToChar (numString[1] - 48);
               int t3 = Convert.ToChar (numString[2] - 48); int t4 = Convert.ToChar (numString[3] - 48);
               //
               if (t1 >= 1 && t2 >= 0) Console.Write ($"{roman_thousand[t1]}");
               //
               if (t2 >= 1 && t3 >= 0) Console.Write ($"{roman_hundred[t2]}");
               //
               if (t3 == 1 && t4 == 0) Console.Write ($"{roman_tens[t3 - 1]}");
               else if (t3 > 1 && t4 == 0) Console.WriteLine ($"{roman_tens_2[t3]}");
               else if (t3 == 1 && t4 >= 1) Console.WriteLine ($"{roman_tens[t4]}");
               else if (t3 > 1 && t4 >= 1) Console.Write ($"{roman_tens_2[t3]}{roman_ones[t4]}");
               //
               if (t2 == 0 && t3 == 0 && t4 != 0) Console.Write ($"{roman_ones[t4]}");
               else if (t2 != 0 && t3 == 0 && t4 != 0) Console.Write ($"{roman_ones[t4]}");
               else if (t1 == 0 && t2 == 0 && t3 == 0 && t4 != 0) Console.Write ($"{roman_ones[t4]}");
               Console.WriteLine ("\n\nNote: In Roman numerals the symbol '^' is not valid " +
                  "due to IDE constrain it has been done, kindly refer internet.");
            } else if (numLen == 3) {
               int t1 = Convert.ToChar (numString[0] - 48); int t2 = Convert.ToChar (numString[1] - 48);
               int t3 = Convert.ToChar (numString[2] - 48);
               //
               if (t1 != 0) Console.Write ($"{roman_hundred[t1]}");
               //
               if (t2 == 1 && t3 == 0) Console.Write ($"{roman_tens[t2 - 1]}");
               else if (t2 == 1 && t3 >= 1) Console.Write ($"{roman_tens[t3]}");
               else if (t2 > 1 && t3 == 0) Console.WriteLine ($"{roman_tens_2[t2]}");
               else if (t2 > 1 && t3 >= 1) Console.Write ($"{roman_tens_2[t2]}{roman_ones[t3]}");
               //
               if (t1 == 0 && t2 == 0 && t3 != 0) Console.Write ($"{roman_ones[t3]}");
               else if (t2 == 0 && t3 != 0) Console.Write ($"{roman_ones[t3]}");
            } else if (numLen == 2) {
               int t1 = Convert.ToChar (numString[0] - 48); int t2 = Convert.ToChar (numString[1] - 48);
               //
               if (t1 == 1 && t2 == 0) Console.Write ($"{roman_tens[t1 - 1]}");
               else if (t1 == 1 && t2 >= 1) Console.Write ($"{roman_tens[t2]}");
               else if (t1 > 1 && t2 == 0) Console.WriteLine ($"{roman_tens_2[t1]}");
               else if (t1 > 1 && t2 >= 1) Console.Write ($"{roman_tens_2[t1]}{roman_ones[t2]}");
               //
               if (t1 == 0 && t2 != 0) Console.Write ($"{roman_ones[t2]}");
            } else if (numLen == 1) {
               int t1 = Convert.ToChar (numString[0] - 48);
               if (t1 != 0) Console.Write ($"{roman_ones[t1]}");
               else Console.Write ("none, beacuse there is no symbol for zero in Roman numerals\n");
            }
         }
      } else Console.Write ("The length of a given digit is out of range, " +
                         "please type less than (or) equal to 5 digits to get an output\n");
   }
}