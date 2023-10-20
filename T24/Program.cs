// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.
// Program.cs
// <TODO: It is a game where you have to enter the total amount, the price of a chocolate bar,
// and the maximum number of wrappers to exchange for a chocolate bar.
// The output displays the remaining amount, maximum number of chocolates, and remaining wrappers.>
/// <summary> To show the remaining amount, maximum number of chocolates, and remaining wrappers depending on the condition.</summary>
/// <param name="totalAmount">Given money.</param>
/// <param name="priceOfChoco">Price of the chocolate.</param>
/// <param name="wrappers">Maximum numbers of wrappers to exchange the chocolate.</param>
/// <returns> Return values:
/// Invalid input: When you enter other than numbers or enter values less than 1 in the console.
/// 1: Displays the remaining amount, maximum number of chocolates, and remaining wrappers..
/// </returns>

internal class Program {
   static void Main (String[] args) {
      Console.WriteLine ("Enter the value of money you have, price of the chocolate and " +
         "number of a chocolate wrapper to exchange a single chocolate.");
      bool amount = int.TryParse (Console.ReadLine (), out int totalAmount);
      bool price = int.TryParse (Console.ReadLine (), out int priceOfChoco);
      bool wrapper = int.TryParse (Console.ReadLine (), out int wrappers);
      if (!amount || !price || !wrapper || (totalAmount < 1 | priceOfChoco < 1 | wrappers < 1)) {
         Console.WriteLine ("Invaild input");
         return;
      }
      ChocoGames (ref totalAmount, ref priceOfChoco, ref wrappers);
      Console.WriteLine ($"Remaining money: {totalAmount}\nMaxChococount: {priceOfChoco}\nFinal wrapper: {wrappers}");
   }

   static void ChocoGames (ref int totalAmount, ref int priceOfChoco, ref int wrappers) {
      int remainingMoney = totalAmount % priceOfChoco, choco = totalAmount / priceOfChoco;
      List<int> remainingWrapper = new () { choco % wrappers }, chocoCount = new () { choco / wrappers };
      int chocoWrapper = choco / wrappers, x = chocoWrapper / wrappers, y = chocoWrapper % wrappers;
      chocoCount.Add (x);
      remainingWrapper.Add (y);
      while (true) {
         if (x < wrappers) {
            remainingWrapper.Add (x);
            break;
         }
         chocoCount.Add (x /= wrappers);
         remainingWrapper.Add (y %= wrappers);
      }
      int finalWrapper;
      if (remainingWrapper.Sum () < wrappers) finalWrapper = remainingWrapper.Sum ();
      else {
         finalWrapper = remainingWrapper.Sum () / wrappers;
         chocoCount.Add (finalWrapper);
      }
      totalAmount = remainingMoney; priceOfChoco = chocoCount.Sum () + choco; wrappers = finalWrapper;
      return;
   }
}