// Texteditor
Console.WriteLine("Uppgift 2 text editor");
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;

string val = "";


while (true)
{
    Console.WriteLine("""
    1. Skriv till fil 
    2. Läs från fil
    3. Avsluta programmet
    Välj ett av alternativen ovan
    """);
    val = Console.ReadLine();

    if (val == "1")
    {
        Console.WriteLine("Skriv text i filen");
        string texten = Console.ReadLine();
        File.WriteAllText("filnamn.txt", texten);
    }
    else if (val == "2")
    {
        if (File.Exists("filnamn.txt"))
        {
            string texten = File.ReadAllText("filnamn.txt");
            Console.WriteLine(texten);
        }
        else
        {
            Console.WriteLine("Filen finns inte!");
        }
        
    }
    
    else if (val == "3")
    {
        Console.WriteLine("Avslutar");
        break;
    }
    

}
