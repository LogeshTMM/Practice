// REVERSE A GIVEN NUMBER
internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the number to get reverse");
      string n = Console.ReadLine ();
      char[] k = { }; char l; 
      for (int i = 1; i <= n.Length; i++) {
         l = n[i - 1];
         k = k.Append (l).ToArray ();
      }
      Array.Reverse(k);
      Console.WriteLine (k);
   }
}