﻿//Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten. 
using System.Formats.Asn1;

Console.Clear();
Console.WriteLine(""" 
Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.
Marginalskatten räknas ut baserat på din bruttolön.
Med bruttolön avses din årslön före skatt.
""");

Console.WriteLine("Vad heter du?");
string namn = Console.ReadLine();

// Programloop
while (true)
{
    Console.WriteLine("Ange din bruttolön i kronor: ");
    int bruttolön = int.Parse(Console.ReadLine());

    // Har användaren matat in något vettigt?
    if (bruttolön < 10000 || bruttolön > 1000000)
    {
        Console.WriteLine("Du har matat in en ogiltig summa pengar det måste vara mellan 1000 och 1000000, var snäll och försök igen");
    }
    else
    {

        //Vad är skattesatsen? 
        // * 10000:- till 145000:- -> 22%
        int skattesatsen = 0;  // Skapa variabelm skattesatsen
        if (bruttolön >= 10000 && bruttolön <= 145000)
        {
            skattesatsen = 22;
        }
        // * 145000:- till 515000:- -> 33%
        if (bruttolön >= 14500 && bruttolön <= 515000)
        {
            skattesatsen = 33;
        }
        //* 515000:- eller mer -> 53%
        if (bruttolön >= 515000)
        {
            skattesatsen = 53;
        }

        // Skatteuträkning
        int nettolön = bruttolön * (100 - skattesatsen) / 100;

        // Feedback till användaren, resultatet
        Console.WriteLine($"Din nettolön blir {nettolön} kr. Uträkning baserad på bruttolön {bruttolön} kr och marginalskatten {skattesatsen}%.");

    }

    // Vill du göra en ny beräkning? 
    Console.WriteLine("Vill du göra en ny beräkning? j/n");
    string görOm = Console.ReadLine().ToLower().Trim();
    if (görOm == "n")
    {
        break;
    }

}