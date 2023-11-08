//Convert THE  GIVEN DECIMAL NUMBER INTO BASE VALUE OF 16,8 AND 2
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the decimal number ");
      int user_no = Convert.ToInt32 (Console.ReadLine ());
      Console.WriteLine ("\nwhich base value you want to convert\n\tif you want to convert" +
         " Hexadecimal number then press 'h'\n\tif you want to convert Octal then press 'o'" +
         "\n\tif you want to convert Binary numbers then press 'b'\n");
      var user_respond_key = Console.ReadKey (true).KeyChar;
      if (user_respond_key == 'h') Console.WriteLine (Convert.ToString (user_no, 16));
      else if (user_respond_key == 'o') Console.WriteLine (Convert.ToString (user_no, 8));
      else if (user_respond_key == 'b') Console.WriteLine (Convert.ToString (user_no, 2));
      else Console.WriteLine ("Your press the wrong button");
   }
}