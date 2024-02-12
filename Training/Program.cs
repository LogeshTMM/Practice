// ---------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch- July 2023
// Copyright (c) Metamation India.
// ---------------------------------------------------------------------------------------
// Program.cs
// <TODO: Asking a series of questions to find the user's guessed number using the
// binary search algorithm.
// The output shows user guessed number.>
// ---------------------------------------------------------------------------------------

using System;

internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("There is a series of yes or no questions. " +
       "The computer can find your guessing number between 0 to 127. " +
       "\nType Yes to 'y' and No to 'n'");
      if (YesorNo () == 'y') LesserThan64 (); // Initial guess whether the number is less than 64.
      else GreaterThan64 (); // Initial guess whether the number is greater than 64.
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write ("\nYour guessing number is " + sGuessedNum + "\n");
      Console.ResetColor ();
   }

   /// <summary> Checks the user guessed number is less than 64 through initial guess.</summary>
   /// <returns> Return values:
   /// User guessed number through sGuessedNum variable.
   /// </returns>
   private static void LesserThan64 () {
      for (int i = 0, logicGate = 0, arrIndex = 0; i < 6; i++) {
         if (logicGate == 0) {
            if (sChars == 'y') sNum /= 2;
            else {
               sInts[arrIndex++] = sNum * 2;
               logicGate = 1;
            }
         }
         if (logicGate == 1 || sChars == 'n') {
            logicGate = 1;
            if (sChars == 'n') sFactor = sNum;
            sSum = Math.Abs (sFactor - sInts[arrIndex - 1]);
            if (sSum == 0) sSum = Math.Abs (sFactor - sInts[arrIndex - 2]);
            sInts[arrIndex++] = sFactor + (sSum / 2);
            sNum = sInts[arrIndex - 1];
         }
         YesorNo ();
         if (i == 5) _ = (sChars == 'y') ? sGuessedNum = sFactor :
                          sGuessedNum = sInts[arrIndex - 1];
      }
   }

   /// <summary> Checks the user guessed number is greater than 64 through initial guess.</summary>
   /// <returns> Return values:
   /// User guessed number through sGuessedNum variable.
   /// </returns>
   private static void GreaterThan64 () {
      for (int i = 0, logicGate = 0, arrIndex = 0; i < 6; i++) {
         if (logicGate == 0) {
            if (sChars == 'n') {
               int[] ints = { 32, 16, 8, 4, 2, 1 };
               sFactor = sNum;
               sNum += ints[i];
            } else {
               sInts[arrIndex++] = sNum; logicGate = 1;
            }
         }
         if (logicGate == 1 || sChars == 'y') {
            logicGate = 1;
            if (sChars == 'n') {
               sFactor = sNum;
               arrIndex--;
            }
            sSum = Math.Abs (sFactor - sInts[arrIndex - 1]);
            sInts[arrIndex++] = sFactor + (sSum / 2);
            sNum = sInts[arrIndex - 1];
         }
         YesorNo ();
         if (i == 5 && arrIndex != 0) _ = sChars == 'y' ? sGuessedNum = sFactor :
                         sGuessedNum = sInts[arrIndex - 1];
         else if (i == 5 && arrIndex == 0) sGuessedNum = sNum;
      }
   }

   /// <summary> Checks whether the user input is valid or not.</summary>
   /// <returns> Return values:
   /// Error Message: "Please try again if you have entered incorrectly", 
   /// if the user input neither y nor n.
   /// y:  Return the character 'y' to the method that needs it.
   /// n:  Return the character 'n' to the method that needs it.
   /// </returns>
   private static char YesorNo () {
      for (; ; ) {
         Console.Write ($" is your number less than {sNum}: ");
         char chars = Console.ReadKey ().KeyChar;
         Console.WriteLine ();
         if (chars == 'y' || chars == 'n') return sChars = chars;
         Console.WriteLine ("Please try again if you have entered incorrectly.");
      }
   }

   static int sNum = 64, sFactor, sSum, sGuessedNum;
   static readonly int[] sInts = new int[6];
   static char sChars;
}