// whether is ABECEDARIAN WORD (or) NOT
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the word to check ABECEDARIAN WORD or not");
      string a = Console.ReadLine ().ToLower (); var b = a.ToCharArray (); var c = new List<int> (); int d; var c_dup = new List<int> ();
      //Console.WriteLine (b[0] == 97);
      //Console.WriteLine (a.Length);
      for (int i = 0; i < a.Length; i++) {
         d = b[i] - 96;
         c.Add (d);
      }
      //c.CopyTo(c_dup); 
      //c.GetRange (0, c.Count);
      c_dup = c.GetRange (0, c.Count);
      Console.WriteLine ("Length of a given word is " + c.Count);
      c_dup.Sort ();
      //foreach (var e in c) Console.Write (e + " "); Console.WriteLine ();
      //foreach (var e in c_dup) Console.Write (e + " ");
      bool isequal = Enumerable.SequenceEqual (c, c_dup);
      if (isequal) Console.WriteLine ($"{a} is an ABECEDARIAN WORD");
      else Console.WriteLine ($"{a} is not an ABECEDARIAN WORD");
   }
}