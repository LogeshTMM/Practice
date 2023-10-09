// SWAP INDICES
internal class Program {
   List<int> ints;
   static void Main () {
      Console.WriteLine ("Random number series given below");
      Random rnd = new ();
      List<int> ints = new () { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      for (int i = 0; i < ints.Count; i++) {
         int number = rnd.Next (i, ints.Count);
         (ints[i], ints[number]) = (ints[number], ints[i]);
      }
      foreach (int j in ints) Console.Write (j + " ");
      Console.WriteLine ("\nJust type the two index numbers to swap");
      bool firstValue = int.TryParse (Console.ReadLine (), out int num1);
      bool secondValue = int.TryParse (Console.ReadLine (), out int num2);
      if (!firstValue || !secondValue) Console.WriteLine ("Invaild input");
      else SwapFunc (num1, num2, ints);
   }
   static void SwapFunc (int a, int b, List<int> ints) {
      if (!(a <= ints.Count && b <= ints.Count)) Console.WriteLine ("Index out of range");
      else {
         (ints[a], ints[b]) = (ints[b], ints[a]);
         Console.Write ("After swapping the values in the number series: ");
         foreach (var c in ints) Console.Write (c + " ");
      }
   }
}