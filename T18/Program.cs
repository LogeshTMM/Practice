// WHETHER IS AN ARMSTRONG NUMBER OR NOT
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the number to find whether is an Armstrong number (or) not");
      string input = Console.ReadLine ();
      if (!input.All (char.IsDigit)) {
         Console.WriteLine ("Invalid input");
         return;
      }
      ArmStrong (input);
   }
   static int ArmStrong (string num) {
      int b, result = 0;
      foreach (int a in num) {
         b = a - 48; /* ASCII CODE FOR 1 is 49, assume that a subtract by 48 (a - 48;) to get int value 1. According to 'char 1'.*/
         result += (int)(Math.Pow (b, num.Length));
      }
      if (int.Parse (num) == result) Console.WriteLine ("Given number is an Armstrong number");
      else Console.WriteLine ("Given number is not an Armstrong number");
      return result;
   }
}