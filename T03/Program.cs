//FIBONNACI SERIES
internal class Program {
   static void Main () {
      var fb_list = new List<int> { 0, 1, 1 };
      Console.WriteLine ("Enter the nth term of a Fibonnaci series, to find the value and along with the series");
      if (int.TryParse (Console.ReadLine (), out int n) && n >= 1) {
         for (int i = 0; i < n; i++) fb_list.Add (fb_list[^1] + fb_list[^2]);
         Console.Write ($"Fibonnaci series is ");
         for (int i = 0; i < n; i++) Console.Write (fb_list[i] + " ");
         Console.WriteLine ($"\nThe value of {n}th term in fibonnaci series is {fb_list[n - 1]}");
      } else Console.WriteLine ("Invaild Input");
   }
}