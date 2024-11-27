Console.Clear();
//1. Skapa en lista med 5 namn 
List<string> Namn = ["Krul", "Frank", "Badam", "Pär", "Kim"];
Console.WriteLine($"Mina kompisar är: {string.Join(", ", Namn)}");

Console.WriteLine("");

//2. Skapa en lista med 5 orter
List<string> orter = ["Stockholm", "Göteborg", "Malmö", "Uppsala", "Västerås"];
Console.WriteLine($"Fem orter: {string.Join(", ", orter)} i Sverige"); 

Console.WriteLine("");

// 3. Skapa en lista med 5 årtal
List<int> årtal = [1249, 1450, 70, 3000, 1390];
Console.WriteLine($"Fem viktiga årtal: '{string.Join("', '", årtal)}'");

Console.WriteLine("");


// 4. Visa första och sista objektet i en lista
// Skapa en lista av typen List<string> som innehåller 5 namn.
List<string> listaNamn = ["Krul", "Frank", "Badam", "Pär", "Kim"];
Console.WriteLine("Första namnet: " + listaNamn[0]);
Console.WriteLine("Sista namnet: " + listaNamn[4]);

Console.WriteLine("");

// 5. Skapa en lista med 5 favoritdrycker
Console.WriteLine("Favorti drycker: ");
List<string> listDryck = ["Cola", "Sprite", "Fanta", "Mer", "Festis"];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{i+1}. {listDryck[i]}");
}

Console.WriteLine("");

//6. Skapa en lista med födelseår
Console.WriteLine("Födelseår: ");
List<string> listFödelsedag = ["1356","54","1987", "1345", "2024"];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{i+1}. {listFödelsedag[i]}");
}

Console.WriteLine("");
//7. Lägg till ett namn baserat på en variabel
Console.WriteLine("Nuvarande lista: ");

List<string> listnamn = ["Melvin", "Tim"];

Console.WriteLine($"Namn lista: {string.Join(", ", listnamn)}");

Console.Write("Nytt namn att lägga till");

string nyttnamn = Console.ReadLine();

listnamn.Add(nyttnamn);

Console.WriteLine($"Namn lista: {string.Join(", ", listnamn)}");

Console.WriteLine("");

// 8. Lägg till ett årtal baserat på en variabel

Console.WriteLine("Nuvarande lista: ");

List<string> listårtal = ["1987", "1978"];

Console.WriteLine($"Årtal lista: {string.Join(", ", listårtal)}");

Console.Write("Nytt årtal att lägga till");

string nyttårtal = Console.ReadLine();

listårtal.Add(nyttårtal);

Console.WriteLine($"Årtal lista: {string.Join(", ", listårtal)}");

//9. Kontrollera om ett namn redan finns


List<string> listanamn = ["Erik", "Sven", "Gunnar"];

string nyttnamnn = Console.ReadLine();

if (listanamn.Contains(nyttnamnn))
{
    Console.WriteLine($"{nyttnamnn} finns redan i listan.");
}
else
{
    listanamn.Add(nyttnamnn);
    Console.WriteLine(string.Join(", ", listanamn));
}

