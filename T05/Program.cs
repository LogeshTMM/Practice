// GIVEN NUMBER IS PRIME NUMBER (OR) NOT A PRIME NUMBER
internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the number to find prime number or not");
      int i = Convert.ToInt32 (Console.ReadLine ());
      if (i % 2 == 0) Console.WriteLine ($"{i} is not a prime number");
      else Console.WriteLine ($"{i} is a prime number");
   }
}