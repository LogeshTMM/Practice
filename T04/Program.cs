//TO FIND LCM BETWEEN FOUR INPUT VALUES
internal class Program {
   static void Main () {
      int a, b, c, d;
      Console.WriteLine ("Enter the value of a, b, c and d, to find LCM between them");
      a = Math.Abs (Convert.ToInt32 (Console.ReadLine ()));
      b = Math.Abs (Convert.ToInt32 (Console.ReadLine ()));
      c = Math.Abs (Convert.ToInt32 (Console.ReadLine ()));
      d = Math.Abs (Convert.ToInt32 (Console.ReadLine ()));
      int[] max_value = { a, b, c, d };
      int n = max_value.Max ();
      while (n != 0) {
         if (n % a == 0 && n % b == 0 && n % c == 0 && n % d == 0) {
            Console.WriteLine ($"\nTherefore LCM of a given number series is {n}");
            break;
         }
         n++;
      }
      //TO FIND GCD BETWEEN TWO INPUT VALUES
      Console.WriteLine ("\n\nEnter the value of e and f, to find LCM and GCD between them");
      int e = Math.Abs (Convert.ToInt32 (Console.ReadLine ()));
      int f = Math.Abs (Convert.ToInt32 (Console.ReadLine ()));
      int m = Math.Max (e, f);
      while (m != 0) {
         if (m % e == 0 && m % f == 0) {
            Console.WriteLine ($"\nTherefore LCM of a given number series is {m}");
            break;
         }
         m++;
      }
      if (m != 0) {
         int p = (e * f) / m;
         Console.WriteLine ($"\nTherefore GCD of a given number series is {p}");
      }
   }
}