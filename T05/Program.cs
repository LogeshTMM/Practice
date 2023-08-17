// GIVEN NUMBER IS PRIME NUMBER (OR) NOT A PRIME NUMBER USING SQUARE ROOT N METHOD
internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the number to check it's a prime number (or) not");
      double n = Convert.ToInt32 (Console.ReadLine ()), m = Math.Sqrt (n);
      int h = Convert.ToInt32 (Math.Round (m)); int i;
      for (i = 2; i < h; i++) {
         //Console.WriteLine (i);
         if (h % i == 0) {
            Console.WriteLine ($"\n{n} is not a prime number");
            break;
         }
      }
      //Console.WriteLine (i);
      if (h == i) Console.WriteLine ($"\n{n} is a prime number");
   }
}