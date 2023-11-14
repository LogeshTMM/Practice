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
         Console.WriteLine ("Invalid input");
         return;
      }
      Console.Write ("Enter the price of the chocolate: ");
      int.TryParse (Console.ReadLine (), out int priceOfChoco);
      if (priceOfChoco < 1) {
         Console.WriteLine ("Invalid input");
         return;
      }
      Console.Write ("Enter the number of a chocolate wrappers to exchange a single chocolate: ");
      _ = int.TryParse (Console.ReadLine (), out int wrappers);
      if (wrappers <= 1) {
         Console.WriteLine ("Invalid input");
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
   /// <param name="maxChocoCount">Total number of chocolates in the end.</param>
   /// <param name="BalanceMoney">Remaining money after buyed the chocolates.</param>
   /// <param name="wrappersRemaining">Remaining wrappers after exchange the chocolates.</param>
   /// <returns> Return values:
   /// Displays the remaining amount, maximum number of chocolates, and remaining wrappers..
   /// </returns>
   static void ChocoGames (int totalAmount, int priceOfChoco, int wrappers, ref int maxChocoCount,
      ref int BalanceMoney, ref double wrappersRemaining) {
      BalanceMoney = totalAmount % priceOfChoco; maxChocoCount = totalAmount / priceOfChoco;
      int getChoco = maxChocoCount / wrappers;
      wrappersRemaining = maxChocoCount % wrappers;
      double wrappersToExchange = getChoco + wrappersRemaining; // Get the chocolates based on the remaining wrappers.
      maxChocoCount += getChoco;
      for (; ; ) {
         getChoco = Convert.ToInt32 (wrappersToExchange) / wrappers;
         maxChocoCount += getChoco;
         wrappersRemaining = wrappersToExchange % wrappers;
         wrappersToExchange = getChoco + wrappersRemaining;
         if (wrappersToExchange < wrappers) {
            wrappersRemaining += getChoco;
            return;
         }
      }
   }
}