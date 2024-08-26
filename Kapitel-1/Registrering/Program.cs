// Program för att registrera förnamn och efternamn...
using System.Runtime.CompilerServices;

Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Program för att registrera förnamn och efternamn");
Console.WriteLine("Ange förnamn");
string förnamn = Console.ReadLine();
//Console.WriteLine("Ange efternamn");
string efternamn = Console.ReadLine();
Console.WriteLine("Hej! " + förnamn + " " + efternamn);
Console.WriteLine($"Hej! {förnamn} {efternamn}");

// Är det Eli som loogar in?
if (förnamn == "Eli" )
{
    Console.WriteLine("Vad trevligt att du är tillbaka");
}


{
    
}