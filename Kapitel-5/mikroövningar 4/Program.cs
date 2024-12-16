Console.Clear();
Console.WriteLine("Mikroövningar 4");

List<string> actionspelLista = [];

actionspelLista.Add("Actionspel1");
actionspelLista.Add("Actionspel2");

List<string> äventyrspelLista = [];

äventyrspelLista.Add("äventyrspel1");
äventyrspelLista.Add("Äventyrspel2");




Console.WriteLine("Nu ska du fylla i två äventyrspel i listan");
for (var i = 0; i < 2; i++)
{
    Console.WriteLine("Ange ett äventyrspel:");
string äventyrspel = Console.ReadLine();
actionspelLista.Add(äventyrspel);
}

while (true)
{


    Console.WriteLine("Nu ska du fylla i två action-spel i listan");
    Console.WriteLine("Ange ett actionspel:");
    string actionspel = Console.ReadLine();
    actionspelLista.Add(actionspel);
    Console.WriteLine($"Alla namn: {actionspel}");
}
