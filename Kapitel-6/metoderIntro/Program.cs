/***************************************************
********************* M A I N **********************
****************************************************/

Console.Clear();
Console.WriteLine("Hej metoder!");

//anropa/använd metoden
SägHej();
SägHej();
SägHej();
SägHej();
SägHej();

//anropa med metoden meny 
VisaMeny();

//anropa metoden
RegistreraNamn();


/***************************************************
**************** M E T O D E R *********************
****************************************************/

/// <summary>
/// Metod som skriver ut en hälsning 
/// </summary>

static void SägHej()
{
    Console.WriteLine("Hej på dig!");
}


/// <summary>
/// Metod för att visa meny
/// </summary>
static void VisaMeny()
{
Console.WriteLine("""
1. Lägg till uppgift 
2. Ta bort uppgift 
3. Skriv ut alla uppgifter
4. Avsluta
""");
}

/// <summart>
/// Metod för att ange namn
/// </summary> 
static void RegistreraNamn()
{
Console.WriteLine("Ange namn:");
string namn = Console.ReadLine();
Console.WriteLine(namn);
}