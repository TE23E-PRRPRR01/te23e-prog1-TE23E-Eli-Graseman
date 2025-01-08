Console.Clear();

List<string> namnLista = [];


while (true)
{
    
Console.WriteLine("Fyll i listan");

        string svar = Console.ReadLine();
if (svar == "exit")
{
    break;
}
namnLista.Add(svar);
}


foreach (var namn in namnLista)
{
    Console.WriteLine(namn);
}
