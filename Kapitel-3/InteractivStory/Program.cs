// If satser
using System.Runtime.CompilerServices;

Console.Clear();
Console.WriteLine("Välkommen till detta spel");
// Alternativen
Console.Write("Gillar du...?(j/n) ");
string svar = Console.ReadLine().ToLower();
// Antingen ja eller nej
if (svar == "ja")
{
   Console.WriteLine("Vad roligt. Jag antar att du är najs....?");
   if (svar == "ja")
   {
      Console.WriteLine("Shit vad najs?");
      if (svar == "ja")
      {
         System.Console.WriteLine("najs");
      }
      else
      {
         System.Console.WriteLine("onajs");
      }
   }
   else
   {
      System.Console.WriteLine("Nähä vad onajs. Jag antar att du är onajs...?");
   }
}
else
{
   System.Console.WriteLine("Nähä vad onajs");
}
