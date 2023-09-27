// WHETHER IS AN ARMSTRONG NUMBER OR NOT
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the number to find whether is an Armstrong number (or) not");
      string input = Console.ReadLine ();
      if (!input.All (char.IsDigit)) {
         Console.WriteLine ("Invalid input");
         return;
      }
      int result = 0;
      foreach (int a in input) ArmStrong (a - 48); /* ASCII CODE FOR 1 is 49, assume that a subtract by 48 (a - 48;) 
                                                     to get int value 1. According to 'char 1'.*/
      if (int.Parse (input) == result) Console.WriteLine ("Given number is an Armstrong number");
      else Console.WriteLine ("Given number is not an Armstrong number");

      int ArmStrong (int b) {
         result += (int)(Math.Pow (b, input.Length));
         return result;
      }
   }
}