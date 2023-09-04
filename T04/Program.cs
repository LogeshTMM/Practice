//TO FIND GCD BETWEEN TWO INPUT VALUES
internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the value of a and b, to find LCM and GCD between them");
      int.TryParse (Console.ReadLine (), out int a);
      int.TryParse (Console.ReadLine (), out int b);
      int m = Math.Max (a, b);
      while (m != 0) {
         if (m % a == 0 && m % b == 0) {
            Console.WriteLine ($"\nLCM of {a} and {b} is {m}");
            break;
         }
         m++;
      }
      if (m != 0) {
         int p = (a * b) / m;
         Console.WriteLine ($"\nGCD of {a} and {b} is {p}");
      }
   }
}