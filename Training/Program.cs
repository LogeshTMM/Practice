using complexNumber;
using System;

internal class Program {
   static void Main (string[] args) {
      double aReal, aImg, bReal, bImg;
      ComplexNumber number = new ();
      Console.Write ("Enter the first complex number followed by real number: ");
      for (; ; ) if (double.TryParse (Console.ReadLine (), out aReal)) break;
      Console.Write ("Enter the first complex number followed by imaginery number: ");
      for (; ; ) if (double.TryParse (Console.ReadLine (), out aImg)) break;
      Console.Write ("Enter the second complex number followed by real number: ");
      for (; ; ) if (double.TryParse (Console.ReadLine (), out bReal)) break; ;
      Console.Write ("Enter the second complex number followed by imaginery number: ");
      for (; ; ) if (double.TryParse (Console.ReadLine (), out bImg)) break; ;
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