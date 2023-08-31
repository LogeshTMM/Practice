//FIBONNACI SERIES
internal class Program {
   static void Main () {
      int[] fb = { 0, 1, 1 };
      int lk;
      Console.WriteLine ("Enter the nth term of s fibonnaci series, to find the value and along with the series");
      int n = Convert.ToInt32 (Console.ReadLine ());
      for (int i = 0; i < n; i++) {
         lk = fb[fb.Length - 1] + fb[fb.Length - 2];
         fb = fb.Append (lk).ToArray (); if (i == n - 3) break;
      }
      Console.WriteLine ($"\nFibonnaci series of {n}th term is");
      foreach (int j in fb) {
         Console.Write ($"{j} ");
      }
      Console.WriteLine ($"\n\n{n}th term value of fibonnaci series is {fb[n]}\n");
   }
}