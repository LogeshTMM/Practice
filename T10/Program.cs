// REVERSE A GIVEN NUMBER
internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the number to get the reverse order of it");
      string input = Console.ReadLine ();
      if (!input.All (char.IsDigit)) {
         Console.WriteLine ("Invaild input");
         return;
      }
      char[] reverseInputArray = Array.Empty<char> ();
      Console.Write ("Reverse order of given number is" + " ");
      for (int i = input.Length - 1; i >= 0; i--) {
         char item = input[i];
         Console.Write (item);
         reverseInputArray = reverseInputArray.Append (item).ToArray ();
      }
      if (string.Equals (input, new string (reverseInputArray))) Console.Write ("\nIt's a palindrome");
      else Console.Write ("\nIt's not a palindrome");
   }
}