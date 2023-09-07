// REVERSE A GIVEN NUMBER
internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the number to get the reverse order");
      int.TryParse (Console.ReadLine (), out int n);
      if (n == 0) Console.WriteLine ("Invaild Input");
      else {
         var org_n = n.ToString ();
         Console.Write ("Reverse order of given number is" + " ");
         for (int i = org_n.Length; i != 0; i--) Console.Write (org_n[i - 1]);
      }
   }
}