Console.Clear();
Console.WriteLine("Filmregister");

// Lista för att lagra filmer
List<string> listaFilmer = [];

//Be användaren ange ett antal


Console.Write("Ange ett antal filmer per sida (3-5)");
string antalText = Console.ReadLine();
int antal = 0;
while (true)
{
    bool success = int.TryParse(antalText, out antal);
    if (success)
    {
        break;
    }
    
}

//Program loop
while (true)
{
    //Visa en meny
    Console.WriteLine("""
1. Lägg till filmer 
2. Lista alla filmer 
3. Sök en film
4. Avsulta
Välj ett alternativ
""");
    string val = Console.ReadLine();

    //Hantera med valet
    if (val == "1")
    {
        //Lägg till filmer i listan 
        for (int i = 0; i < antal; i++)
        {
            Console.WriteLine("Ange en film att lägga till");
            string film = Console.ReadLine();
            listaFilmer.Add(film);
        }

    }
    else if (val == "2")
    {
        //Skriv ut alla filmer 
        foreach (var filmnamn in listaFilmer)
        {
            Console.WriteLine(filmnamn);
        }
    }
    else if (val == "3")
    {
        //Sök en film 
        Console.WriteLine("Ange en film att söka efter (första bokstaven): ");
        string bokstav = Console.ReadLine();
                foreach (var filmnamn in listaFilmer)
        {
            if (filmnamn.StartsWith(bokstav))
            {
                Console.WriteLine(filmnamn);
            }
        }
        
    }
    else if (val == "4")
    {
       Console.WriteLine("Tack för idag");
        break;
    }
    else
    {
        Console.WriteLine("Fel val försök igen");
    }
}


