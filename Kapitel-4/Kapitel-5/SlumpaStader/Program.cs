// Slumpa städer
Console.Clear();
Console.WriteLine("Slumpa Städer!");


List<string> städer = ["Karlstad", "Halmstad", "Skellefteå", "Stockholm", "Västerås", "Göteborg", "Nyköping", "Luelå", "Kiruna"];

int antal = 2; 
while (antal > 0)
{
    int index = Random.Shared.Next(0, 10);
    
    string stad = städer [index]; 

    Console.WriteLine($"Den slumpade staden är {stad}");
    antal--; 
}