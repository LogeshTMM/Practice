// FACTORIAL OF A GIVEN NUMBER
internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the number to known it's factorial value");
      if (!uint.TryParse (Console.ReadLine (), out uint input)) {
         Console.WriteLine ("Invaild input");
         return;
      }
      Console.WriteLine ($"Factorial of {input} is : {Factorial (input)}");
   }
   static ulong Factorial (uint n) {
      if (n == 1) return 1;
      return n * Factorial (n - 1);
   }
}