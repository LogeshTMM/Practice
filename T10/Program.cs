// REVERSE A GIVEN NUMBER
internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the number to get the reverse order");
      bool res = ulong.TryParse (Console.ReadLine (), out ulong input);
      if (!res) {
         Console.WriteLine ("Invaild input"); return;
      } else {
         var org_input = input.ToString (); var rev = Array.Empty<char> ();
         if (input != 0) {
            Console.Write ("Reverse order of given number is" + " ");
            for (int i = org_input.Length; i != 0; i--) {
               Console.Write (org_input[i - 1]);
               rev = rev.Append (org_input[i - 1]).ToArray ();
            }
            if (string.Equals (org_input, new string (rev))) Console.Write ("It's a palindrome");
            else Console.Write ("\nIt's not a palindrome");
         }
      }
   }
}