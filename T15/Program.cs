// TO CHECK GIVEN WORD IS AN ISOGRAM OR NOT
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the word");
      string input = Console.ReadLine ().ToLower ();
      if (!input.All (char.IsLetter)) {
         Console.WriteLine ("Invaild input");
         return;
      }
      int inputLen = input.Length, count = 0;
      for (int i = 0; i < inputLen; i++) {
         for (int j = 1; j < inputLen; j++) {
            if (input[i] == input[j]) count++;
            if (count == 1) {
               Console.WriteLine ("Given word is not an Isogram.");
               return;
            }
         }
      }
      Console.Write ("Given word is an Isogram.");
   }
}