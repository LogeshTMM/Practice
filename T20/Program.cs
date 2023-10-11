// Display the individual digits of a given number
internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the decimal number to display it's integral and factorial part");
      if (decimal.TryParse (Console.ReadLine (), out decimal input)) {
         if (int.TryParse (input.ToString (), out int inputints)) {
            Console.WriteLine ($"Integral part of a given decimal value is {inputints}" +
               $"\nFactorial part of a given decimal value is none");
            return;
         }
         string[] inputDecimal = input.ToString ().Split ('.');
         Console.WriteLine ($"Integral part of a given decimal value is {inputDecimal[0]}" +
                         $"\nFactorial part of a given decimal value is {inputDecimal[1]}");
      } else Console.WriteLine ("Invaild input");
   }
}