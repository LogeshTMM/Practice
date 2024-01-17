// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.
// Program.cs
// <TODO: Arrange the list and swap special characters at the end of it.
// The output is orderd list either ascending (or) descending order and swap the
// special characters at the end of it>
// ---------------------------------------------------------------------------------------
internal class Program {
   static void Main (String[] args) {
      string input;
      while (true) {
         Console.Write ("Enter the word to be sorting: ");
         input = Console.ReadLine ();
         if (input.All (char.IsLetter) && input.Length > 3) break;
         Console.WriteLine ("Reason: It should not be a text, or the length of the word should be less than 3.\n");
      }
      List<char> charList = input.ToList ();
      string specialChar;
      while (true) {
         Console.Write ("Enter the single alphabet character: ");
         specialChar = Console.ReadLine ();
         if (specialChar.All (char.IsLetter) && specialChar != "" && specialChar.Length == 1) break;
         Console.WriteLine ("Reason: It should not be a letter or the length of the character should not be equal to 1.\n");
      }
      Console.Write ("Type 'd' to descending order (or) press enter to default mode (ascending order)" + " ---> ");
      string order = Console.ReadLine ().ToLower ();
      if (order == "d")
         Console.WriteLine (string.Join (",", SortChars (charList, Convert.ToChar (specialChar),
            charList.Count, Convert.ToChar (order))));
      else Console.WriteLine (string.Join (",", SortChars (charList, Convert.ToChar (specialChar), charList.Count)));
   }

   #region SortChars Method ---------------------------------------------------------------------
   /// <summary>Sort the list and swap the special special characters at the end of it.</summary>
   /// <param name="lists">Maybe an unsorted list got it from the user.</param>
   /// <param name="specialChar">single special character from (A-Z).</param>
   /// <param name="sort">Determine the order of the unsorted list.</param>
   /// <returns> Return values:
   /// (Default): Organize the list in ascending order and swap the special characters at the end.
   /// d: Organize the list in descending order and swap the special characters at the end.
   /// </returns>
   static List<char> SortChars (List<char> lists, char specialChar, int len, char sort = 'a') {
      lists.RemoveAll (a => a.Equals (specialChar));
      List<char> sortedList = sort == 'd' ? lists.OrderByDescending (x => x).ToList () : lists.Order ().ToList ();
      sortedList.AddRange (Enumerable.Repeat (specialChar, len - sortedList.Count));
      return sortedList;
   }
   #endregion
}