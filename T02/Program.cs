// CONVERT THE GIVEN NUMBER INTO WORD FORMAT AND ROMAN NUMERALS FORMAT
internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the number to convert into words and roman numerals:");
      string input = Console.ReadLine ();
      if (!input.All (char.IsDigit) | input == "") {
         Console.WriteLine ("Invaild input");
         return;
      }
      ConvertToWordAndRoman (input);
   }

   static void ConvertToWordAndRoman (string input) {
      if (input.Length > 4) {
         Console.WriteLine ("Please enter the number which is lesser or equal to four digits.");
         return;
      }
      Dictionary<int, string> numToWords = new () { {0,"ZERO"},{ 1,"ONE"},{2,"TWO"},{3,"THREE"},{4,"FOUR"},{5,"FIVE"},{6,"SIX"},{7,"SEVEN"},{8,"EIGHT" },
                                                    {9,"NINE"},{10,"TEN"},{11,"ELEVEN"},{ 12,"TWELEVE"},{ 13,"THIRTEEN"},{14,"FOURTEEN" },{15,"FIFTEEN"},
                                                    {16,"SIXTEEN"},{17,"SEVENTEEN"},{18,"EIGHTEEN"},{19,"NINETEEN"},{20,"TWENTY"},{30,"THIRTY"},{ 40,"FORTY"},
                                                    {50,"FIFTY"},{ 60,"SIXTY"},{ 70,"SEVENTY"},{80,"EIGHTY"},{90,"NINETY"} };
      Dictionary<int, string> numToRomans = new () { {1,"I"},{2,"II"},{3,"III"},{4,"IV"},{5,"V"},{6,"VI"},{7,"VII"},{8,"VIII"},{9,"IX"},
                                                     {10,"X"},{11,"XI"},{12,"XII"},{13,"XIII"},{14,"XIV"},{15,"XV"},{16,"XVI"},{ 17,"XVII"},{18,"XVIII"},
                                                     {19,"XIX"},{20,"XX"},{30,"XXX"},{40,"XL"},{50,"L"},{60,"LX"},{70,"LXX"},{ 80,"LXXX"},{90,"XC"},{100,"C"},
                                                     {200,"CC"},{300,"CCC"},{400,"CD"},{500,"D"},{600,"DC"},{700,"DCC"},{800,"DCCC"},{900,"CM"},{1000,"M"},
                                                     {2000,"MM"},{3000,"MMM"},{4000,"MMMM"},{5000,"^V"},{6000,"^VM"},{7000,"^VMM"},{8000,"^VMMM"},{9000,"MX^"}};
      int[] inputIntsArray = Array.Empty<int> ();
      foreach (int a in input) inputIntsArray = inputIntsArray.Append (a - 48).ToArray ();
      Console.WriteLine ("\nIf you want to convert numbers to word format, then press 'w'" + "\nIf you want to convert numbers to roman numerals, then press 'r'\n" +
            "If you want to convert numbers to both word format and roman numerals, then press 'b'");
      var userRespondKey = Console.ReadKey (true).KeyChar;
      char[] vaildKey = { 'w', 'r', 'b' };
      if (!vaildKey.Contains (userRespondKey)) {
         Console.WriteLine ("\nYou press the wrong button, try again");
         return;
      }
      var inputLastTwoInts = 0;
      if (input.Length > 2) inputLastTwoInts = Convert.ToInt32 (input[^2..]);
      Console.Write ($"\nThe Word format for a given number is ");
      if (userRespondKey == 'w' || userRespondKey == 'b') {
         switch (input.Length) {
            case 4:
               for (int nthPlace = input.Length; nthPlace != 0; nthPlace--) {
                  switch (nthPlace) {
                     case 4:
                        if (inputIntsArray[0] != 0) Console.Write (numToWords[inputIntsArray[0]] + " " + "THOUSAND" + " ");
                        break;
                     case 3:
                        if (inputIntsArray[1] != 0) Console.Write (numToWords[inputIntsArray[1]] + " " + "HUNDRED" + " ");
                        break;
                     case 2:
                        if (numToWords.TryGetValue (inputLastTwoInts, out string value) & inputLastTwoInts > 10) Console.Write ("and" + " " + value);
                        else if (inputIntsArray[2] != 0 && inputIntsArray[3] >= 1) {
                           int x = (inputLastTwoInts / 10) * 10, y = inputLastTwoInts % 10;
                           Console.Write (numToWords[x] + " " + numToWords[y] + " ");
                        }
                        break;
                     case 1:
                        if (inputIntsArray[2] == 0 && inputIntsArray[3] != 0) Console.Write ("and" + " " + numToWords[inputIntsArray[3]]);
                        break;
                  }
               }
               break;
            case 3:
               for (int nthPlace = input.Length; nthPlace != 0; nthPlace--) {
                  switch (nthPlace) {
                     case 3:
                        if (inputIntsArray[0] != 0) Console.Write (numToWords[inputIntsArray[0]] + " " + "HUNDRED" + " ");
                        break;
                     case 2:
                        if (numToWords.TryGetValue (inputLastTwoInts, out string value)) Console.Write (value + " ");
                        else if (inputIntsArray[1] != 0 && inputIntsArray[2] >= 1) {
                           int x = (inputLastTwoInts / 10) * 10, y = inputLastTwoInts % 10;
                           Console.Write (numToWords[x] + " " + numToWords[y] + " ");
                        }
                        break;
                     case 1:
                        if (inputIntsArray[1] == 0 && inputIntsArray[2] != 0) Console.Write (numToWords[inputIntsArray[2]]);
                        break;
                  }
               }
               break;
            case 2:
               for (int nthPlace = input.Length; nthPlace != 0; nthPlace--) {
                  switch (nthPlace) {
                     case 2:
                        if (numToWords.TryGetValue (inputLastTwoInts, out string value)) Console.Write (value + " ");
                        else if (inputIntsArray[0] != 0 && inputIntsArray[1] >= 1) {
                           int x = (inputLastTwoInts / 10) * 10, y = inputLastTwoInts % 10;
                           Console.Write (numToWords[x] + " " + numToWords[y] + " ");
                        }
                        break;
                     case 1:
                        if (inputIntsArray[0] == 0 && inputIntsArray[1] != 0) Console.Write (numToWords[inputIntsArray[1]]);
                        break;
                  }
               }
               break;
            case 1:
               if (inputIntsArray[0] >= 0) Console.Write (numToWords[inputIntsArray[0]]);
               break;
         }
      }
      Console.Write ($"\nThe Roman numerals format for a given number is ");
      if (userRespondKey == 'r' || userRespondKey == 'b') {
         switch (input.Length) {
            case 4:
               for (int nthPlace = input.Length; nthPlace != 0; nthPlace--) {
                  switch (nthPlace) {
                     case 4:
                        if (inputIntsArray[0] != 0) Console.Write (numToRomans[inputIntsArray[0] * 1000]);
                        break;
                     case 3:
                        if (inputIntsArray[1] != 0) Console.Write (numToRomans[inputIntsArray[1] * 100]);
                        break;
                     case 2:
                        if (numToRomans.TryGetValue (inputLastTwoInts, out string value)) {
                           Console.Write (value + " ");
                           return;
                        } else if (inputIntsArray[2] != 0 && inputIntsArray[3] >= 1) {
                           int x = (inputLastTwoInts / 10) * 10, y = inputLastTwoInts % 10;
                           Console.Write (numToRomans[x] + numToRomans[y]);
                        }
                        break;
                     case 1:
                        if (inputIntsArray[2] == 0 && inputIntsArray[3] != 0) Console.Write (numToRomans[inputIntsArray[3]]);
                        break;
                  }
               }
               break;
            case 3:
               for (int nthPlace = input.Length; nthPlace != 0; nthPlace--) {
                  switch (nthPlace) {
                     case 3:
                        if (inputIntsArray[0] != 0) Console.Write (numToRomans[inputIntsArray[0] * 100]);
                        break;
                     case 2:
                        if (numToRomans.TryGetValue (inputLastTwoInts, out string value)) Console.Write (value + " ");
                        else if (inputIntsArray[1] != 0 && inputIntsArray[2] >= 1) {
                           int x = (inputLastTwoInts / 10) * 10, y = inputLastTwoInts % 10;
                           Console.Write (numToRomans[x] + numToRomans[y]);
                        }
                        break;
                     case 1:
                        if (inputIntsArray[1] == 0 && inputIntsArray[2] != 0) Console.Write (numToRomans[inputIntsArray[2]]);
                        break;
                  }
               }
               break;
            case 2:
               for (int nthPlace = input.Length; nthPlace != 0; nthPlace--) {
                  switch (nthPlace) {
                     case 2:
                        if (numToRomans.TryGetValue (inputLastTwoInts, out string value)) Console.Write (value + " ");
                        else if (inputIntsArray[0] != 0 && inputIntsArray[1] >= 1) {
                           int x = (inputLastTwoInts / 10) * 10, y = inputLastTwoInts % 10;
                           Console.Write (numToRomans[x] + numToRomans[y]);
                        }
                        break;
                     case 1:
                        if (inputIntsArray[0] == 0 && inputIntsArray[1] != 0) Console.Write (numToRomans[inputIntsArray[1]]);
                        break;
                  }
               }
               break;
            case 1:
               if (inputIntsArray[0] != 0) Console.WriteLine (numToRomans[inputIntsArray[0]]);
               else if (inputIntsArray[0] == 0) Console.WriteLine ("none, beacuse there is no symbol for zero in Roman numerals");
               break;
         }
      }
      if (inputIntsArray[0] >= 5) Console.WriteLine ("\n\nNote: Due to IDE constraints, the symbol '^' is not valid in Roman numerals. Refer to the internet.");
   }
}