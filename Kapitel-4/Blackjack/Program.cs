﻿// Spelet BlackJack, även kallat 21:an
Console.WriteLine("Spelet blackjack");
Console.Clear();

// Kortens värde är
// 2-10 = 2-10
//Knekt, dam, kunde = 10
// Ess = 1 (eller 11)
// @todo slump måste efterlikna riktig kortlek, dvs 4x1,4x2....4xkung

// Variabler 
int summaSpelare = 0;
int summaDator = 0;
int kort = 0;

// Dela ut 2 kort till spelaren
kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
summaSpelare += kort;
kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
summaSpelare += kort;
// Dela ut 2 kort till datorn
kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
summaDator += kort;
kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
summaDator += kort;

// Flera gånger (loop)
while (true)
{
    // Skriv ut summorna
    Console.WriteLine($"Du har {summaSpelare} poäng");
    Console.WriteLine($"Datorn har {summaDator} poäng");

    // Stanna eller dra ett kort?
    Console.WriteLine("Vill du ha ett nytt kort? (j/n)");
    string svar = Console.ReadLine().ToLower();
    if (svar == "n")
    {

        if (summaDator > summaSpelare)
        {
            kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
            summaDator += kort;
            Console.WriteLine($"Datorn har  {kort} poäng");
        }
        else
        {
            if (summaDator <= 10)
            {
                kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
                summaDator += kort;
                Console.WriteLine("Datorn har {kort} poäng");
            }
        }
        //@todo datorn får ta extra kort <=17
        while (summaDator < 17)
        {
            kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
            summaDator += kort;
        }


        //Vem har vunnit?
        // Den som har närmast 21 har vunnit 
        if (summaSpelare > summaDator && summaSpelare < 21)
        {
            Console.WriteLine("Du har vunnit!");
        }
        else
        {
            Console.WriteLine("Du har förlorat!");
        }
        break;
    }


    // Ta ett extra kort
    kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
    summaSpelare += kort;
    // Skriv ut kortet 
    Console.WriteLine($"Du fick {kort}");

    //Datorn får också ett nytt kort 
    kort = Random.Shared.Next(1, 11); // @todo knekt, dam och kung?
    summaDator += kort;
    // Skriv ut kortet 
    Console.WriteLine($"Datorn fick {kort}");


    // Stanna om man vill
    // Vem har vunnit? shit
    //Har datorn fått 21 o vunnit?
    if (summaDator == 21)
    {
        Console.WriteLine("Datorn har vunnit!");
        break;

    }
    //Har spelaren fått 21 har han vunnit 
    if (summaSpelare == 21)
    {
        Console.WriteLine("Du har vunnit!");
        break;

    }

    // Är spelaren tjock
    if (summaSpelare > 21)
    {
        Console.WriteLine("Du har förlorat för du är tjock som fan!");
        break;
    }
    // Är datorn tjock?
    if (summaDator == 21)
    {
        Console.WriteLine("Datorn har förlorat för att den är tjock som fan!");
        break;
    }

}