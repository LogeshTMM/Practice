// Training ~ A training program for new joinees at Metamation, Batch- July 2023

// Copyright (c) Metamation India.

// Program.cs

// <TODO: To seperate the integral and factorial part from a given decimal number.

// When an output shows an invalid input, then you enter other than numbers.

// If you enter the decimal number to visualize the integral and factorial part of it.>

internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the decimal number to display it's integral and factorial part");
      if (decimal.TryParse (Console.ReadLine (), out decimal input)) {
         string[] inputDecimal = input.ToString ().Split ('.');
         if (inputDecimal.Length == 1) {
            Console.WriteLine ($"Integral part of a given decimal value is {inputDecimal[0]}" +
               $"\nFactorial part of a given decimal value is 0");
            return;
         }
         Console.WriteLine ($"Integral part of a given decimal value is {inputDecimal[0]}" +
                         $"\nFactorial part of a given decimal value is {inputDecimal[1]}");
      } else Console.WriteLine ("Invaild input");
   }
}