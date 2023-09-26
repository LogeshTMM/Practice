// DIGITAL ROOT
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the number to find digital root");
      ulong.TryParse (Console.ReadLine (), out ulong num);
      if (num == 0) {
         Console.WriteLine ("Invaild input");
         return;
      }
      var num_dup = num.ToString (); var num_ints = new List<int> ();
      foreach (int j in num_dup) num_ints.Add (j - 48);
      Console.WriteLine ($"\nThe digital root for {num} is {num_ints.Sum ()}");
      Console.WriteLine ("\nUSES\n1. To identify whether the number is divisible by '3' or '9' quickly.\n" +
         "2. To find the remainder in a few seconds for the divisor '9'\n" +
         "3. To check the answer for +,-,*,/, square root and cube root.\n" +
         "4. To find whether the number is a perfect square within seconds.");
   }
}