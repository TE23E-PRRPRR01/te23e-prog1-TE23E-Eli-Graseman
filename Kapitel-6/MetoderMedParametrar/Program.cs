/***************************************************
**************** M A I N       *********************
****************************************************/
Console.Clear();



// Skriv ut ett medelande vertikalt
string meddelande = "Månadg!";
//SkrivVertikal(meddelande);

// Skriv ut ett medelande vertikalt nr 2
string meddelande1 = "tisdag är bättre";
//SkrivVertikal(meddelande1);

// Skriv ut ett medelande vertikalt nr 3
string meddelande2 = "Onsdag är bäst";
//SkrivVertikal(meddelande2);



//Rita ut en fyrkant med sidlängd3

//Kvadrat(3);

//blablbalbalbla
//UpprepaText("hej", 3);
//UpprepaText("hejsan", 5);



/***************************************************
****************   M E T O D E R    ****************
****************************************************/
/// <summary>
/// 
/// </summary>
/// <param name="meddelande"></param>
static void SkrivVertikal(string meddelande)
{
    for (var i = 0; i < meddelande.Length; i++) // 0->6
    {
        Console.WriteLine(meddelande[i]);
    }

}

static void Kvadrat(int sidlängd )
{
    for (var i = 0; i < sidlängd; i++)
    {
        for (var j = 0; j < sidlängd; j++)
        {
            Console.Write("+");
        }
        Console.WriteLine();
    }
}

static void UpprepaText(string text, int antal)
{
    for (var i = 0; i < antal; i++)
    {
        Console.WriteLine(text);
    }
}

static void OmvandlaCTillF(int celcius)
{
 int fahrenheit = celcius * 9/5 + 32;
 Console.WriteLine($"{celcius} grader Celcius motsvarar {fahrenheit} grader Fahrenheit");
}

static void tärning(int antal)
{
    for (var i = 0; i < antal; i++)
    {
        Console.WriteLine($"Tärningen visar {Random.Shared.Next}
    }
}