// Convert THE GIVEN DECIMAL NUMBER INTO BASE VALUE OF 16,8 AND 2
internal class Program {
   static void Main (string[] args) {
      Console.Write ("Enter the decimal based numbers ---> ");
      if (!int.TryParse (Console.ReadLine (), out var userNum)) {
         Console.WriteLine ("Invaild input");
         return;
      }
      Console.WriteLine ("which base value you want to convert\n\t1. If you want to convert" +
         " Hexadecimal number then press 'h'.\n\t2. If you want to convert Octal then press 'o'." +
         "\n\t3. If you want to convert Binary numbers then press 'b'.\n");
      switch (Console.ReadKey (true).KeyChar) {
         case 'h':
            Console.WriteLine ("Hexadecimal number is " + Convert.ToString (userNum, 16));
            break;
         case 'o':
            Console.WriteLine ("Octal number is " + Convert.ToString (userNum, 8));
            break;
         case 'b':
            Console.WriteLine ("Binary Number is " + Convert.ToString (userNum, 2));
            break;
         default:
            Console.WriteLine ("You pressed the wrong button.");
            break;
      }
   }
}