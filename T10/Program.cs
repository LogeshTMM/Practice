// REVERSE A GIVEN NUMBER
internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the number to get the reverse order of it");
      if (!ulong.TryParse (Console.ReadLine (), out ulong input)) {
         Console.WriteLine ("Invaild input");
         return;
      }
      var stringInput = input.ToString (); var reverseInputArray = Array.Empty<char> ();
      if (input != 0) {
         Console.Write ("Reverse order of given number is" + " ");
         for (int i = stringInput.Length; i != 0; i--) {
            Console.Write (stringInput[i - 1]);
            reverseInputArray.Append (stringInput[i - 1]).ToArray ();
         }
         if (string.Equals (stringInput, new string (reverseInputArray))) Console.Write ("It's a palindrome");
         else Console.Write ("\nIt's not a palindrome");
      } else Console.WriteLine ("Invaild input");
   }
}