// DIGITAL ROOT
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the number to find digital root");
      int dummy; var num_ints = new List<int> ();
      if (ulong.TryParse (Console.ReadLine (), out ulong num)) {
         var num_dup = num.ToString ();
         var chararray = num_dup.ToCharArray ();
         //Console.Write (chararray);
         //Console.WriteLine ($"\n{chararray.Length}");
         foreach (int j in chararray) {
            dummy = j - 48;
            num_ints.Add (dummy);
            //Console.WriteLine (d);
         }
         //Console.WriteLine (ints.ToArray());
         int sum = num_ints.Take (chararray.Length).Sum ();
         Console.WriteLine ($"\nThe digital root for {num} is {sum}");
         Console.WriteLine ("\nUSES\n1. To identify whether the number is divisible by '3' or '9' quickly.\n" +
            "2. To find the remainder in a few seconds for the divisor '9'\n" +
            "3. To check the answer for +,-,*,/, square root and cube root.\n" +
            "4. To find whether the number is a perfect square within seconds.");
      } else Console.WriteLine ("Invaild Input");
   }
}