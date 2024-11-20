
while (true)
{
    

      Console.WriteLine("Jämna siffror:");
    for (int i = 0; i <= 21; i ++)
    {
        if (i % 2 == 0)
        {
            Console.Write($" {i}");
        }
    }

    Console.WriteLine("Udda siffror:");
    for (int i = 1; i < 21; i ++)
    {
        if (i % 2 != 0)
        {
            Console.Write($" {i}");
        }
    }

    int tal = int.Parse(Console.ReadLine());

    for (int i = 0; i < 11; i++)
    {
        Console.WriteLine($"{tal}x{i} = {tal * i}");
    }
}

