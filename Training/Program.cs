using Udouble;
using System;

internal class Program {
   static void Main (string[] args) {
      Console.Write ("Enter the number: ");
      Console.WriteLine (UserDouble.Parse (Console.ReadLine ()));
   }
}