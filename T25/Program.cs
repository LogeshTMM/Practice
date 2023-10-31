// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.
// Program.cs
// <TODO: Arrange the list and swap special characters at the end of it.
// The output is orderd list either ascending (or) descending order and swap the
// special characters at the end of it>

# region -- Main program for SORT AND SWAP SPECIAL CHARACTERS
internal class Program {
   static void Main (String[] args) {
      Console.Write ("Enter the word to be sorting" + " ---> ");
      string input = Console.ReadLine ();
      if (!input.All (char.IsLetter) | input.Length < 3) {
         Console.WriteLine ("Invaild input (or) Length of the word should be lesser than 3");
         return;
      }
      List<char> lists = input.ToList ();
      Console.Write ("Enter the single alphabet character" + " ---> ");
      string specialChar = Console.ReadLine ();
      if (!specialChar.All (char.IsLetter) | specialChar == "" | specialChar.Length != 1) {
         Console.WriteLine ("Invaild input (or) Length of the char should not be equal to 1");
         return;
      }
      Console.Write ("Type 'd' to descending order (or) press enter to default mode (ascending order)" + " ---> ");
      string order = Console.ReadLine ();
      if (order == "d") SortChars (ref lists, Convert.ToChar (specialChar), Convert.ToChar (order));
      else SortChars (ref lists, Convert.ToChar (specialChar));
      Console.Write (string.Join (" ", lists));
   }

   #region --- SortChars Method
   /// <summary>Sort the list and swap the special special characters at the end of it.</summary>
   /// <param name="lists">unsorted list got it from the user.</param>
   /// <param name="specialChar">single special character.</param>
   /// <param name="sort">Determine the order of the unsorted list.</param>
   /// <returns> Return values:
   /// (Default): Organize the list in ascending order and swap the special characters at the end.
   /// d: Organize the list in descending order and swap the special characters at the end.
   /// </returns>
   static void SortChars (ref List<char> lists, char specialChar, char sort = 'a') {
      List<char> sortedList = new (), specialCharsList = new ();
      if (sort == 'a') {                                            // 'a' denotes ascending order.
         while (lists.Count != 0) {
            char minChar = lists[0];
            foreach (char a in lists) if (minChar > a) minChar = a; // find the minimum character in the lists.
            if (specialChar != minChar) sortedList.Add (minChar);
            else specialCharsList.Add (minChar);
            lists.Remove (minChar);
         }
      } else if (sort == 'd') {                                     // 'd' denotes descending order.
         while (lists.Count != 0) {
            char maxChar = lists[0];
            foreach (char b in lists) if (maxChar < b) maxChar = b; // find the maximum character in the lists.
            if (specialChar != maxChar) sortedList.Add (maxChar);
            else specialCharsList.Add (maxChar);
            lists.Remove (maxChar);
         }
      }
      for (int i = 0; i < specialCharsList.Count; i++) sortedList.Add (specialCharsList[i]);  // adding special characters at last of the sorted list.
      lists = sortedList;
   }
   #endregion
}#endregion