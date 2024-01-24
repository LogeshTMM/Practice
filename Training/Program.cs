using complexNumber;
using System;

internal class Program {
   static void Main (string[] args) {
      ComplexNumber number = new ();
      Console.Write ("Enter the first complex number followed by real number: ");
      _ = double.TryParse (Console.ReadLine (), out double aReal);
      Console.Write ("Enter the first complex number followed by imaginery number: ");
      _ = double.TryParse (Console.ReadLine (), out double aImg);
      Console.Write ("Enter the second complex number followed by real number: ");
      _ = double.TryParse (Console.ReadLine (), out double bReal);
      Console.Write ("Enter the second complex number followed by imaginery number: ");
      _ = double.TryParse (Console.ReadLine (), out double bImg);
      Console.WriteLine ("\nResult of addition operation between two complex numbers is :"
         + number.Addition (aReal, aImg, bReal, bImg));
      Console.WriteLine ("\nResult of subtraction operation between two complex numbers is :"
         + number.Subraction (aReal, aImg, bReal, bImg));
      Console.WriteLine ("\nResult of magnitude operation between first complex numbers is :"
         + number.Magnitude (aReal, aImg));
      Console.WriteLine ("\nResult of magnitude operation between second complex numbers is :"
         + number.Magnitude (aReal, aImg));
   }
}