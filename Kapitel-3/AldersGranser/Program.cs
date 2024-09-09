// Vad jag tycker du får göra i olika åldrar

Console.Clear(); 
Console.WriteLine("Hej! Välkommen till denna frågeställning där jag uttrycker vad jag tycker du får göra beroende på din ålder!");


Console.WriteLine("Ange din ålder");
string dinÅlder = Console.ReadLine();
int ålder = int.Parse(dinÅlder);

if (ålder == 12) 
{
    Console.WriteLine("Du börjar högstadiet");
}

if (ålder == 7)
{
    Console.WriteLine("Du börjar skolan påriktigt");
}
if (ålder == 64)
{
    Console.WriteLine("Du får nu gå i pension. Grattis!");
}
if (ålder >= 15 && ålder <= 18)  // åldersspann
{
    
}
