/***************************************************
**************** M A I N       *********************
****************************************************/

Console.Clear();
Console.WriteLine("Hej Metoder!");

SägHejNamn("Valentin");
SägHejNamn("Johnny");
SägHejNamn("Benjamin");
SägHejNamn("");
TalIKvadrat(3);


/***************************************************
**************** M E T O D E R *********************
****************************************************/

/// <summary>
/// Skriv ut hälsning 
/// </summary>
/// <param name="namn">Namnet</param>


static void SägHejNamn(string namn)
{
    Console.WriteLine($"Hej på dig {namn}!");
}

//Metod som skriver ett tal i kvadrat 
static void TalIKvadrat(int tal)
{
Console.WriteLine($"{tal} i kvadrat = {tal * tal}");
}