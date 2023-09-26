// WHETHER IS AN ARMSTRONG NUMBER OR NOT
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the number to find whether is an Armstrong number (or) Not");
      string input = Console.ReadLine ();
      if (!input.All (char.IsDigit)) {
         Console.WriteLine ("Invalid input");
         return;
      }
      double sum = 0;
      int result = 0, inputInts;
      foreach (int a in input) {
         inputInts = a - 48; // ASCII CODE FOR 1 is 49, here I sub a by 48 (inputInts = a-48;) to get int value 1. 
         ArmStrong (inputInts);
      }
      if (int.Parse (input) == result) Console.WriteLine ("Given number is an Armstrong number");
      else Console.WriteLine ("Given number is not an Armstrong number");
      int ArmStrong (int b) {
         sum = Math.Pow (b, input.Length);
         result += (int)sum;
         return result;
      }
   }
}