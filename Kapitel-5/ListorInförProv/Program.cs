Console.Clear();

List<string> namnLista = ["Eli", "Charlie", "Benjamin"]; 
Console.WriteLine("Namnlistan:");
foreach (var namn in namnLista)
{
    Console.WriteLine(namn);
}

for (var i = 0; i < 2 ; i++)
{
Console.WriteLine("Lägg till två namn i listan");
string svar = Console.ReadLine();
namnLista.Add(svar);
}

Console.WriteLine(" ");
foreach (var namn in namnLista)
{
    Console.WriteLine(namn);
}

while (true)
{
    
Console.WriteLine("Sök efter ett namn i listan (klicka exit för att avsluta)");
string svaret = Console.ReadLine();
if (namnLista.Contains(svaret))
{
    Console.WriteLine($"{svaret} finns i listan");
}
else
{
    Console.WriteLine($"{svaret} finns inte i listan var snäll och försök igen");
}

if (svaret == "exit")
{
    break;
}
}