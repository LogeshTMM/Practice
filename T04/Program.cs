//TO FIND GCD BETWEEN TWO INPUT VALUES
internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the value of a and b, to find LCM and GCD between them");
      int.TryParse (Console.ReadLine (), out int a);
      int.TryParse (Console.ReadLine (), out int b);
      if (a == 0 || b == 0) Console.WriteLine ("\nInvaild Input");
      else {
         int m = Math.Max (a, b);
         while (m != 0) {
            if (m % a == 0 && m % b == 0) {
               Console.WriteLine ($"LCM of a given number {a} and {b} is {m}");
               break;
            }
            m++;
         }
         if (m != 0) {
            int p = (a * b) / m;
            Console.WriteLine ($"GCD of a given number {a} and {b} is {p}");
         }
      }
   }
}