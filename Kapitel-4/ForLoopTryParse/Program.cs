Console.Clear();
// Skapa en loop som körs 10 gånger.
// Varje gång loopen körs ska den skriva ut ditt namn
Console.WriteLine("Ange ditt namn");
string namn = Console.ReadLine();
while (true)
{
    Console.WriteLine("Ange en siffra mellan 1-10");
    int siffra = int.Parse(Console.ReadLine());
    
    for (int i = 1; i <= siffra; i++)
    {
        Console.WriteLine($"{i}. {namn}");
    }
}
