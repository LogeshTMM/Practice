using System;

Console.WriteLine ("Hello, World!");
for (int i = 0; i < 10; i++)
   Console.Write ($"{i}   ");
Console.Write ("\nEnter name: ");
var line = Console.ReadLine ();
Console.WriteLine ("{0} {1}!!", "Hello", line);
Console.WriteLine ();