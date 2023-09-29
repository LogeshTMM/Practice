// REVERSE A GIVEN NUMBER
internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the number to get the reverse order of it");
      string input = Console.ReadLine ();
      if (!input.All (char.IsDigit)) {
         Console.WriteLine ("Invaild input");
         return;
      }
      List<char> reverseInputArray = new ();
      Console.Write ("Reverse order of given number is" + " ");
      for (int i = input.Length - 1; i >= 0; i--) {
         Console.Write (input[i]);
         reverseInputArray.Add (input[i]);
      }
      var item = new string (reverseInputArray.ToArray ());
      if (string.Equals (input, item)) Console.Write ("\nIt's a palindrome");
      else Console.Write ("\nIt's not a palindrome");
   }
}