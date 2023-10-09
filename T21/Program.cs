// SWAP A GIVEN NUMBER
internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the vaules of a and b");
      bool firstValue = int.TryParse (Console.ReadLine (), out int a);
      bool secondValue = int.TryParse (Console.ReadLine (), out int b);
      if (!firstValue || !secondValue) Console.WriteLine ("Invaild input");
      else SwapTwoNumbers (a, b);
   }
   static void SwapTwoNumbers (int b, int a) {
      Console.WriteLine ("Do you want to swap the values of a and b, then press 'y'.");
      char userKey = Console.ReadKey (true).KeyChar;
      if (userKey == 'y') Console.Write ($"After swapping the values of\na = {a} \nb = {b}");
      else Console.WriteLine ("Sorry, you press the wrong button.");
   }
}