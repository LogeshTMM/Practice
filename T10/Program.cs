// REVERSE A GIVEN NUMBER
internal class Program {
   static void Main () {
      Console.WriteLine ("Enter the number to get reverse");
      string n = Console.ReadLine ();
      var chararray = n.ToCharArray ();
      Array.Reverse (chararray);
      Console.WriteLine (chararray);
   }
}