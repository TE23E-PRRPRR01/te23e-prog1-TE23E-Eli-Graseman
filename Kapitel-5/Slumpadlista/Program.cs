// Slumpa många tal och spara i lista
Console.Clear();
Console.WriteLine("Slumpa många tal och spara i lista");
    // Globala variabler
    // En lista för heltal 
    List<int> listaSlumptal = [];
    
    
    // Be användare ange antal slumpade tal
    Console.WriteLine("Ange antal tal du vill slumpa");
    int antal = int.Parse(Console.ReadLine());

    // Be användaren ange min & max slumptal
    Console.WriteLine("Ange det minsta slumptalet");
    int min = int.Parse(Console.ReadLine());
    Console.WriteLine("Ange det högsta slumptal värdet");
    int max = int.Parse(Console.ReadLine());


// Loopa 5 gånger 
for (int i = 0; i < antal; i++)
{
    // Slumpa ett tal 1-100
    int slumptal = 0;
    slumptal = Random.Shared.Next(min, max + 1);

    // Lägg till slumptalet i listan
    listaSlumptal.Add(slumptal);
    Console.WriteLine($"Slmuptal tal {i}: {slumptal}");
}
