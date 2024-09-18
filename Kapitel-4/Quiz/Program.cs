//Quiz
int points = 0;
Console.Clear();
Console.WriteLine("Hej och välkommen till min quiz");
Console.WriteLine("Ange namn?");
string namn = Console.ReadLine();
Console.WriteLine($"Hej! {namn} hoppas att du är redo på att köra lite quiz");
Console.WriteLine("TRIGGER WARINING JAG ÄR JUDE SÅ FÅR SKRIVA VAD JAG VILL");

Console.WriteLine("""
Fråga 1: Vad är den kemiskabetäckningen för guld?(a/b/c)
a) Ag
b) Au
c) Cu
""");
string answer = Console.ReadLine();
if (answer == "b")
{
    points++;
    Console.WriteLine("Snyggt!! Det är korrekt!");
}
else
{
    Console.WriteLine("Tyvärr fel");
}

Console.WriteLine("""
Fråga 2: Vilken är den smidigaste tunneln under New York? (a/b/c)
a) דרך חלקה
b) כסף ערמומי בדרך
c) נתיב הכסף
""");
answer = Console.ReadLine();
if (answer == "a")
{
    points++;
    Console.WriteLine("Snyggt du är på god väg");
}
else
{
    Console.WriteLine("Hur fan fick du fel haram!!");
}

Console.WriteLine("""
Vad är den mest judiska saken?
a) Att vara väldigt erbjudande
b) Vara "tight" med sina pengar
c) Att donera massor 
""");
answer = Console.ReadLine();
if (answer == "b")
{
    points++;
    Console.WriteLine("Shit du kan fan");
}
else
{
   Console.WriteLine("Nazist");
}

Console.WriteLine("""
Vad är den bästa valutan att spara pengar i?
a) Svenska Riksdaler
b) Yuan
c) Guld
""");
answer = Console.ReadLine();
if (answer == "c")
{
    Console.WriteLine("Jude");
}
else
{
    Console.WriteLine("Du verkar inte tänka på dina pengar");
}
Console.WriteLine(" Konggratulationer! Du oficilet konverterat till Judendomen (maybe)");
Console.WriteLine("Du fick " + points + "/4 poäng!");