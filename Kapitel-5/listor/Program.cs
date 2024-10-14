// Använda listor för att skapa/hantera samlingar
using System.Runtime.ConstrainedExecution;

Console.Clear();

// Lista på trevliga frukter, tex "äpple"; "apelsin", "annanas" 
List<string> frukter = ["äpple","apelsin", "annanas" ];

Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]} ");

// Ändra i lista:
frukter[0] = "Banan";
Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]} ");

// gå igenom listan = loopa listan = från första till sista
foreach (var frukt in frukter)
{
    Console.WriteLine(frukt);
}

// Skapa en lista på valfri sak (4st)
//Skriv ut varje sak på samma rad

List<string> fordonslista = ["bil","flygplan", "lastbil" ];
foreach (var fordon in fordonslista)
{
    Console.Write($"{fordon}, ");
}
for (int i = 0; i < fordonslista.Count; i++)
{
    Console.Write($"{fordonslista[i]}");
}

//Skapa ett register
// En tom lista 
List<string> namnlista = [];

Console.Clear();

// while loop 
while (true)
{
    Console.Write("Ange ett namn: ");
    string namn = Console.ReadLine();
    namnlista.Add(namn);

    //Skriv ut hela listan på en rad
    foreach (var namnet in namnlista)
    {
        Console.Write($"{namnet}, ");
    }
    Console.WriteLine();


}