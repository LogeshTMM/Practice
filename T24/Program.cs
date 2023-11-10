// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------
// Program.cs
// <TODO: It is a game where you have to enter the total amount, the price of a chocolate bar,
// and the maximum number of wrappers to exchange for a chocolate bar.
// The output displays the remaining amount, maximum number of chocolates, and remaining wrappers.>
// ---------------------------------------------------------------------------------------
internal class Program {
   static void Main (String[] args) {
      Console.Write ("How much money do you have? : ");
      _ = int.TryParse (Console.ReadLine (), out int totalAmount);
      if (totalAmount < 1) {
         Console.WriteLine ("Invaild input");
         return;
      }
      Console.Write ("Enter the price of the chocolate: ");
      _ = int.TryParse (Console.ReadLine (), out int priceOfChoco);
      if (priceOfChoco < 1) {
         Console.WriteLine ("Invaild input");
         return;
      }
      Console.Write ("Enter the number of a chocolate wrappers to exchange a single chocolate: ");
      _ = int.TryParse (Console.ReadLine (), out int wrappers);
      if (wrappers < 1) {
         Console.WriteLine ("Invaild input");
         return;
      }
      int C = 0, X = 0; double W = 0;
      ChocoGames (totalAmount, priceOfChoco, wrappers, ref C, ref X, ref W);
      Console.WriteLine ($"\nRemaining money: {X}\nTotal chocolate: {C}\nRemaining wrapper: {(int)W}");
   }

   /// <summary> To show the remaining amount, maximum number of chocolates, and remaining wrappers depending on the condition.</summary>
   /// <param name="totalAmount">Given money (or) how much money you have?.</param>
   /// <param name="priceOfChoco">Price of the chocolate.</param>
   /// <param name="wrappers">Maximum numbers of wrappers to exchange the chocolate.</param>
   /// <param name="c">Total number of chocolate in the end.</param>
   /// <param name="x">Remaining money after buyed the chocolates.</param>
   /// <param name="w">Remaining wrappers after exchange the chocolates.</param>
   /// <returns> Return values:
   /// Displays the remaining amount, maximum number of chocolates, and remaining wrappers..
   /// </returns>
   static void ChocoGames (int totalAmount, int priceOfChoco, int wrappers, ref int c, ref int x, ref double w) {
      x = totalAmount % priceOfChoco; c = totalAmount / priceOfChoco; // x denotes remaining money after buyed the chocolates.
      int chocoWrapper = c / wrappers;// c denotes Total number of chocolates.
      w = c % wrappers; double y = chocoWrapper + w; // w denotes remaining wrappers after every exchange of the chocolates.
      while (y >= wrappers) { // y denotes (chocowrappers = sum of exchange the wrappers to chocolate) and w. 
         c += chocoWrapper;
         y /= wrappers;
         if (y / wrappers >= 1) w = y / wrappers;
         if (y / wrappers >= 1) chocoWrapper = Convert.ToInt32 (y) / wrappers;
         else {
            c += Convert.ToInt32 (y);
            w = y;
            return;
         }
         y = chocoWrapper + w;
      }
      if ((chocoWrapper + w) < wrappers) {
         c += chocoWrapper;
         w += chocoWrapper;
      }
   }
}