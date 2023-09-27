// TO FIND NTH TERM ARMSTRONG NUMBER
internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Enter the nth number to find the Armstrong number");
      int.TryParse (Console.ReadLine (), out int num);
      if (num == 0) {
         Console.WriteLine ("Invalid input");
         return;
      }
      ArmStrong (num);
   }
   static int ArmStrong (int nthTerm) {
      int count = 0;
      for (int i = 0; i >= 0; i++) {
         int result = 0;
         foreach (int b in i.ToString ()) result += (int)Math.Pow (b - 48, i.ToString ().Length);
         if (i == result) {
            count++;
            if (count == nthTerm) {
               Console.WriteLine ($"{nthTerm} th term of Armstrong number is {i}");
               break;
            }
         }
      }
      return count;
   }
}