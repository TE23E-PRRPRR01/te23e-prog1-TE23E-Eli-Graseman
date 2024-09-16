// Spelet gissa ett slumptal 1-100

using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;

Console.WriteLine("Spelet gissa ett slumptal 1-100");
Console.Clear(); 

// En variabel för att hålla koll på antal gissningar 
int antal = 0;


// Be användaren ange slumptalets gränser med min och max
Console.WriteLine("Ange slumptalets max-värde: ");
int max = int.Parse(Console.ReadLine());
Console.WriteLine("Ange slumptalets min-värde: ");
int min = int.Parse(Console.ReadLine());

//Slumpar ett tal 1-100
int slumptal = Random.Shared.Next(min, max + 1); 
// Upprepning loop 
while (true)
{
    // Ställ fråga till användaren 
    Console.Write($"Gissa ett tal ({min}-{max}): ");
    int gissning = int.Parse(Console.ReadLine()); 

    //Räkna upp antal med 1 
    antal++; 

    // Kontroll om gissning är rätt? 
    if (gissning == slumptal)
    {
        Console.WriteLine("$Rätt gissat på {antal} gånger!");
        break; 
    }
    else if (gissning > slumptal)
    {
        Console.WriteLine("För högt!");
    }
    else
    {
        Console.WriteLine("För lågt");
    }

    // Vill användaren gissa en gång till?
    
    Console.WriteLine("Vill du gissa en gång till (ja/nej): ");
    string svar = Console.ReadLine();
    if ( svar == "nej")
    {
        break;
    }
}

// Slut på spelet 
Console.WriteLine("Slut!, Tack för att du spelade mitt fina spel!");