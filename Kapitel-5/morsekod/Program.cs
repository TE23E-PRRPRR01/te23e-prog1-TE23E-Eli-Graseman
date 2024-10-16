// En liten morsekod app
using System.Runtime.InteropServices;

Console.Clear();
Console.WriteLine("En liten morsekod app");
Console.InputEncoding = System.Text.Encoding.Unicode; 

// Två listor 
List<string> alfabetet = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Å", "Ä", "Ö", "1", "2", "3","4","5","6","7","8", "9","0"];
List<string> moresekod = [ ".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
            "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.",
            "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-",
            "-.--", "--..", ".--.-", ".-.-", "---.", "/" , ".----", "..---","...--","....-", ".....", "-....", "--...", "---..","----.", "-----"];


// Läs in en text
Console.WriteLine("Ange ett medelande");
string medelande = Console.ReadLine();

// Gå igenom meddelandet bokstav för bokstav (loop)
foreach (var bokstav in medelande)
{
    // Uppslag i alfabetet efter index
    int index = alfabetet.IndexOf(bokstav.ToString());

    // Hittar morsetecken A-Ö?
    if (index >= 0)
    {
        //Console.WriteLine($"{bokstav} finns på index {index}");

        // Plocka ut korsetecknet för detta index
        string morsetecken = moresekod[index];
        //Console.WriteLine($"{bokstav} är {morsetecken}");
        Console.Write($"{morsetecken}");

        // Spela upp morse som ljud-beep
        // Tex D= "-.."
        // Dvs loopa igenom morsetecken
        foreach (char signal in morsetecken)
        {
           if (signal == '.')
           {
           // 100HZ, 200ms
            Console.Beep(1000, 300); 
           }
           else // '-'
           {
            Console.Beep(1000, 500);
           }
        }

        //paus i koden 
        Thread.Sleep(100); 
    }
    else
    {
        Console.WriteLine("?");
    }

}









