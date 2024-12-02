// Listor 3

Console.Clear();

//Skriv ut lista i foreach
Console.Clear();

List<string> listfood = ["Pizza", "Sallad", "Pasta"];
Console.WriteLine("Alla maträtter:");
foreach (string food in listfood)
{
    Console.WriteLine($"- {food}");
}

//Skriv ut alla årtalen i en lista

List<string> listårtal = ["1492", "1776", "1914", "1945", "1969"];
Console.WriteLine("Alla årtal i listan:");
foreach (string årtal in listårtal)
{
    Console.WriteLine($"* {årtal}");
}

// Skriv ut på en rad 

//List<string> listår = ["1492,", "1776,", "1914,", "1945,", "1969"];
//Console.Write("Alla årtal i listan:");
//foreach (string år in listår)
//{
    //Console.Write($" {år}");
//}

//Användaren fyller på en lista

List<string> namnlista = [];
while (true)
{

    Console.WriteLine("Ange ett namn att lägga till (eller 'exit' för att avsluta):");
    string namn = Console.ReadLine();
    if (namn == "exit")
    {
        break;
    }
    namnlista.Add(namn);

    Console.WriteLine($"Alla namn: {namn}");
}

// Användaren fyller på en lista med årtal