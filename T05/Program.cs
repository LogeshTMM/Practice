// GIVEN NUMBER IS PRIME NUMBER (OR) NOT A PRIME NUMBER USING SQUARE ROOT N METHOD
internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the number to check it's a prime number (or) not");
      int h = Convert.ToInt32 (Console.ReadLine ()); int i;
      for (i = 2; i < h; i++) {
         if (h % i == 0) {
            Console.WriteLine ($"\n{h} is not a prime number");
            break;
         }
      }
      if (h == i) Console.WriteLine ($"\n{h} is a prime number");
   }
}