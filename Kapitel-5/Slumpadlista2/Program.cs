// Skapa lista med slumpade tal 

/* **************************************************************
**                         Main                                **
*************************************************************** */

// Validera användarens inmatning 
using System.Runtime.Intrinsics.Arm;

Console.Clear();
Console.WriteLine("Hello, World!");

// Deklarerar variabler
//Skapa en lista för att spara det slumpade talet
List<int> listaSlumptal = [];

//Fråga igen tills användaren matar in ett giltigt svar
int antal;
while (true)
{
    // Fråga användaren hur många slumptal som skall skapas 
    Console.Write("Ange antal slumptal : ");
    bool lyckades = int.TryParse(Console.ReadLine(), out antal);
    if (lyckades)
    {
        break;
    }
    else
    {
        Console.WriteLine("Du måste skriva ett heltal");
    }
}
Console.WriteLine($"Du vill ha {antal} slumptal");

//Fråga igen tills användaren matar in ett giltigt svar
int min;
while (true)
{
    // Fråga användaren hur många slumptal som skall skapas 
    Console.Write("Ange lägsta slumptal: ");
    bool lyckades = int.TryParse(Console.ReadLine(), out min);
    if (lyckades)
    {
        break;
    }
    else
    {
        Console.WriteLine("Du måste skriva ett heltal");
    }
}
Console.WriteLine($"Minstaslumptal blir {min}");
int max;
while (true)
{
    // Fråga användaren hur många slumptal som skall skapas 
    Console.Write("Ange högsta slumptal: ");
    bool lyckades = int.TryParse(Console.ReadLine(), out max);
    if (lyckades)
    {
        break;
    }
    else
    {
        Console.WriteLine("Du måste skriva ett heltal");
    }
}
Console.WriteLine($"Högstaslumptal blir {max}");

//slumpa fram ett antal tal
for (int i = 0; i < antal; i++)
{
int slumptal = Random.Shared.Next(min, max + 1);
Console.WriteLine($"ditt nya slumptal är {slumptal}");
}

/* **************************************************************
**                    Mina egna metoder                        **
*************************************************************** */

static int LäsInHeltal()
{
    
}