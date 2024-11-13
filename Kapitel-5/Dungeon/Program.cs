// Ett Dungeon-spel med massa rum, saker, fiender, skatter...
Console.Clear();
Console.WriteLine("Ett Dungeon-spel");

// Programvariabler (state variables)
string rum = "hallen";
List<string> inventarie = [];
int liv = 3;

// Spelloop
while ()
{
    // Är vi i hallen
    if (rum == "hallen")
    {
        Console.WriteLine("Du är i hallen");
        Console.WriteLine("1, Titta runt");
        Console.WriteLine("2, Gå till nästa rum");
        Console.Write("Vad vill du göra");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du tittar runt i rummet och ser några gamla tavlor");
        }
        else if (val == "2")
        {
            rum = "rum 1";
            Console.WriteLine("... du går in i nästa rum...");
        }
    }
    else if (rum == "rum 1")
    {
                Console.WriteLine("Du är i hallen");
        Console.WriteLine("1, Titta runt");
        Console.WriteLine("2. Gå tillbaka till hallen");
        Console.WriteLine("3. Gå till nästa rum");
        Console.Write("Vad vill du göra");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du ser en nyckel på golvet");
            Console.WriteLine("Vill du plocka upp nyckeln?");
            val = Console.ReadLine(). ToLower();
            if (val == "j")
            {
                inventarie.Add("nyckel")
            }
            else
            {
                Console.WriteLine("Du lämnar nyckeln på golvet");
            }

        }
        else if (rum == "2")
        {
            rum = "hallen";
            Console.WriteLine(".. du går tillbaka till hallen...");
        }
    }
    else if (rum == "rum 2 ")
    {
        Console.WriteLine("Du är i rum 2");
        
        //Slumpa en händelse
        int händelse = Rnadom.Shared.Next(1, 5);
        if (händelse == 1)
        {
            Console.WriteLine("Du ser ett svärd på marken. Vill du plocka upp det (j/n)");
            string val = Console.ReadLine(). ToLower();
            if (inventarie.contain("svärd") && val == "j")
            {
                inventarie.Add("svärd")
                Console.WriteLine("Du har nu ett svärd");
            }
            else
            {
                Console.WriteLine("Du orkar inte bära ett svärd till");
            }

        }
        else if (händelse == 2)
        {
            Console.WriteLine("Ett spöke dyker upp ");
            // ...
        }
        else if (händelse == 3)
        {
            Console.WriteLine("Du trampar på en mina och du förlorar ett liv");
            liv--;
            if (liv <= 0)
            {
                break;
            }


        }
        else if (händelse == 4)
        {
            Console.WriteLine("");

        }
    }
}
