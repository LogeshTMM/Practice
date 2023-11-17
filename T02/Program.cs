internal class Program {
   static void Main (string[] args) {
      Console.Write ("Enter the number to convert words and roman numerals: ");
      string num = Console.ReadLine ();
      if (num.All (char.IsLetter) | num.Length >= 5 | num == "") {
         Console.WriteLine ("Invaild input");
         return;
      }
      Dictionary<int, string> numToWords = new () { {0,"ZERO"},{ 1,"ONE"},{2,"TWO"},{3,"THREE"},{4,"FOUR"},{5,"FIVE"},
         {6,"SIX"},{7,"SEVEN"},{8,"EIGHT" },{9,"NINE"},{10,"TEN"},{11,"ELEVEN"},{ 12,"TWELVE"},{ 13,"THIRTEEN"},
         {14,"FOURTEEN" },{15,"FIFTEEN"},{16,"SIXTEEN"},{17,"SEVENTEEN"},{18,"EIGHTEEN"},{19,"NINETEEN"},{20,"TWENTY"},
         {30,"THIRTY"},{ 40,"FORTY"},{50,"FIFTY"},{ 60,"SIXTY"},{ 70,"SEVENTY"},{80,"EIGHTY"},{90,"NINETY"} };
      Dictionary<int, string> numToRomans = new () { {1,"I"},{2,"II"},{3,"III"},{4,"IV"},{5,"V"},{6,"VI"},{7,"VII"},
         {8,"VIII"},{9,"IX"},{10,"X"},{11,"XI"},{12,"XII"},{13,"XIII"},{14,"XIV"},{15,"XV"},{16,"XVI"},{ 17,"XVII"},
         {18,"XVIII"},{19,"XIX"},{20,"XX"},{30,"XXX"},{40,"XL"},{50,"L"},{60,"LX"},{70,"LXX"},{ 80,"LXXX"},{90,"XC"},
         {100,"C"},{200,"CC"},{300,"CCC"},{400,"CD"},{500,"D"},{600,"DC"},{700,"DCC"},{800,"DCCC"},{900,"CM"},{1000,"M"},
         {2000,"MM"},{3000,"MMM"},{4000,"MMMM"},{5000,"^V"},{6000,"^VM"},{7000,"^VMM"},{8000,"^VMMM"},{9000,"MX^"}};
      int[] intsArray = new int[4];
      if (num.Length == 4) for (int x = 0, i = 0; x < 4; x++, i++) intsArray[x] = num[i] - 48;
      else if (num.Length == 3) for (int x = 1, i = 0; x < 4; x++, i++) intsArray[x] = num[i] - 48;
      else if (num.Length == 2) for (int x = 2, i = 0; x < 4; x++, i++) intsArray[x] = num[i] - 48;
      else intsArray[3] = num[0] - 48;
      PrintWords (intsArray, numToWords, num);
      PrintRoman (intsArray, numToRomans, num);
   }

   static void PrintWords (int[] arr, Dictionary<int, string> dic, string input) {
      Console.Write ($"The Word format for a given number is: ");
      string temp = arr[2].ToString () + arr[3].ToString ();
      if (arr[0] != 0) Console.Write (dic[arr[0]] + " " + "THOUSAND" + " ");
      if (arr[1] != 0) Console.Write (dic[arr[1]] + " " + "HUNDRED" + " ");
      if (dic.TryGetValue (Convert.ToInt32 (temp), out string value) && Convert.ToInt32 (temp) != 0)
         Console.Write (value + " ");
      else if (arr[2] != 0) Console.Write (dic[arr[2] * 10] + " " + dic[arr[3]] + " ");
      else if (input.Length == 1) Console.WriteLine (dic[arr[3]]);
   }

   static void PrintRoman (int[] arr, Dictionary<int, string> dic, string input) {
      Console.Write ($"\nThe Roman numerals format for a given number is: ");
      string temp = arr[2].ToString () + arr[3].ToString ();
      if (arr[0] != 0) Console.Write (dic[arr[0] * 1000]);
      if (arr[1] != 0) Console.Write (dic[arr[1] * 100]);
      if (dic.TryGetValue (Convert.ToInt32 (temp), out string value)) Console.Write (value);
      else if (arr[2] != 0 && arr[3] >= 1) Console.Write (dic[arr[2] * 10] + dic[arr[3]]);
      else if (input.Length == 1) Console.WriteLine (dic[arr[3]]);
   }
}