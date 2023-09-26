// WHETHER IS AN ARMSTRONG NUMBER OR NOT
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the number to find whether is an Armstrong Number (or) Not");
      string input = Console.ReadLine ();
      if (!input.All (char.IsDigit)) {
         Console.WriteLine ("Invalid input");
         return;
      }
      double sum = 0;
      int result = 0, inputInts, count = 0;
      int ArmStrong (int b) {
         sum = Math.Pow (b, input.Length);
         result += (int)sum;
         return result;
      }
      foreach (int a in input) {
         inputInts = a - 48;
         ArmStrong (inputInts);
         count++;
      }
      if (count == input.Length) {
         if (Convert.ToInt32 (input) == result) Console.WriteLine ("Given number is an Armstrong Number");
         else Console.WriteLine ("Given number is not an Armstrong Number");
      }
   }
}