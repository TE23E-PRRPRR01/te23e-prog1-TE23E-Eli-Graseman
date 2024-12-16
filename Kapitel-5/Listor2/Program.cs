Console.Clear();
Console.WriteLine("Allt om listor");

//Skapa en tom lista 

List<string> listnamn = [];

//Infoga i en lista
listnamn.Add("Alex"); 
listnamn.Add("Alexander");
Console.WriteLine($"Lista: {listnamn}");

//SKriva ut listan
Console.WriteLine(listnamn);
foreach (var namn in listnamn)
{
    Console.WriteLine($" - {namn}");
}

//Skriv ut första elementet i listan (index = 0)
Console.WriteLine($"Första elementet: {listnamn [0]}");

//Skriv ut två namn ut listan 
for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"- {i}: {listnamn [i]}");
}

//Skriva ut alla namn i listan med for looå
for (var i = 0; i < listnamn.Count; i++)
{
    Console.WriteLine($"");
}