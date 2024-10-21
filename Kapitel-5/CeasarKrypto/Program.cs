// Ett program för kryptering med Ceasar-chiffer
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Ett program för kryptering med Ceasar-chiffer");

// Alfabetet, lista av bokstäver att använda 
string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

// Ange en bokstav
Console.Write("Ange ett meddelande");
string meddelande = Console.ReadLine().ToUpper();


// Ange en nyckel (1-9)
Console.Write("Ange en nyckel 1-9");
int nyckel = int.Parse(Console.ReadLine());

//Loopa igenom meddelandet bokstav för bokstav
foreach (char bokstav in meddelande)
{

    // Hitta bokstavens position (index)
    int index = alfabetet.IndexOf(bokstav);
   // Console.WriteLine($"'{bokstav}' så är index={index}");

    // Om bokstaven finns i alfabetet
    if (index != -1)
    {
        // Caesar-kryptering, addera en nyckel (tex 2)
        int nyIndex = index + 2;
        //Console.WriteLine($"{index} + {nyckel} = {nyIndex}");

        if (nyIndex >= 29)
        {
            nyIndex -= alfabetet.Length;
        }

        // Plocka ut bokstaven för nyIndex
        char krypteradBokstav = alfabetet[nyIndex];
        //Console.WriteLine($"{nyIndex} är bokstaven {krypteradBokstav}");
        Console.Write(krypteradBokstav);
    }
    else
    {
        //Console.WriteLine($"Bokstavem oförändrad: {meddelande}");
        Console.Write(bokstav);
    }

}



