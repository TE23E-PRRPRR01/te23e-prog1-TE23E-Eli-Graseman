/***************************************************
**************** M A I N ********************
****************************************************/
//Använd metoder här!
Console.Clear();

//int svar = Addera(3, 5);
//Console.WriteLine($"Svaret är {svar}");
//Console.WriteLine(Addera(3, 5));
//Console.WriteLine($"3 + 5 = {Addera(3, 5)}");

//string namn = "JOan";
//Console.WriteLine($"{namn} baklänges är {VändText(namn)}");

//int svar = Dividera(10, 2);
//Console.WriteLine($"Svaret är {svar}");

/***************************************************
**************** M E T O D E R    ******************
****************************************************/
//Skapa metoder här!
/// <summary>
/// Summera två tal
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>

//static int Addera(int tal1, int tal2) // Signatur
//{
   // int summa = tal1 + tal2;
   // return summa;
    
//}

/// <summary>
/// Vänder på texten
/// </summary>
/// <param name="text"></param>

static string VändText(string text)
{
    string omvändText = "";
    for (int i = text.Length; - 1 >= 0; i--)
    {
        omvändText += text[i];
    }
    return omvändText;
}

static int Dividera(int tal1, int tal2) // Signatur
{
    int summa = tal1 / tal2;
    return summa;
    
}
/// <summary>
/// Säkert sätt att läsa in ett tal (utan att det krashcar)
/// </summary>
static void LäsInHeltatl()
{
    int tal = 0;
    string textSomBlirTal = Console.ReadLine();
    while (true)
    {
        bool lyckades = int.TryParse(textSomBlirTal, out tal);

    return tal;
    }
}