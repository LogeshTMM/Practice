//FIBONNACI SERIES
internal class Program {
   static void Main () {
      var fb_list = new List<int> { 0, 1, 1 };
      Console.WriteLine ("Enter the nth term of a Fibonnaci series, to find the value and along with the series");
      int.TryParse (Console.ReadLine (), out int n);
      if (n == 0) Console.WriteLine ("Invaild Input");
      else {
         for (int i = 0; i < n; i++) {
            int dummy = fb_list[^1] + fb_list[^2];
            fb_list.Add (dummy);
         }
         Console.WriteLine ($"Fibonnaci series is ");
         foreach (int j in fb_list) Console.Write (j + " "); // (or) foreach (int j in fb_list) Console.Write ($"{j} ");
         Console.WriteLine ($"\n{n}th term value of fibonnaci series is {fb_list[n]}");
      }
   }
}