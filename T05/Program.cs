// GIVEN NUMBER IS PRIME NUMBER (OR) NOT A PRIME NUMBER
internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the number to check it's a prime number (or) not");
      int.TryParse (Console.ReadLine (), out int h); int i;
      if (h == 0) Console.WriteLine ("\nInvaild Input");
      if (h == 1) Console.WriteLine ($"{h} is not a prime number, because a prime number must divisble by itself number and also 1");
      for (i = 2; i < h; i++) {
         if (h % i == 0) {
            Console.WriteLine ($"\n{h} is not a prime number");
            break;
         }
      }
      if (h == i) Console.WriteLine ($"\n{h} is a prime number");
   }
}