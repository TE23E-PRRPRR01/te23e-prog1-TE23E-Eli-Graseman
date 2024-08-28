// Lucktext

using System.ComponentModel;

Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Välkommen till uppgift 3 lucktext");
Console.WriteLine("Ange förnamn"); 
string förnamn = Console.ReadLine();
Console.WriteLine("Ange efternamn");
string efternamn = Console.ReadLine(); 
Console.WriteLine("Ange favorit land");
string land = Console.ReadLine();
Console.WriteLine("Ange favorit mat");
string mat = Console.ReadLine(); 
Console.WriteLine("Om du har en hobby ange den"); 
string hobby = Console.ReadLine(); 
Console.WriteLine($"Hej! {förnamn}, du gillar att resa till {land} det måste vara riktigt skönt att resa dit {förnamn}");
