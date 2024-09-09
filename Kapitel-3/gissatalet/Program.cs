// Ett litet spel - gissa ett hemligt tal
Console.Clear(); 
Console.WriteLine("Ett litet spel - gissa ett hemligt tal");

// Slumpa ett tal
int slumptalet = Random.Shared.Next(1, 101); // 1-100
 Console.WriteLine($"Slumptalet är {slumptalet}");

Console.Write("Gissa ett tal 1-100)");
 // Läs in texten, tex "100"
 string gissningText= Console.ReadLine();

 //Konvertera texten till ett heltal, blir 100

int gissning = int.Parse(gissningText); 

if (gissning == slumptalet)
{
    Console.WriteLine("Bra, du har gissat rätt");
}
else if (gissning > slumptalet)
{
    Console.WriteLine("För högt!");
}
else
{
    Console.WriteLine("För lågt!");
}

