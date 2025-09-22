using System.Security.Cryptography;

string task = "csharp3"; // Skift til opgaven der skal køres
Console.Clear();
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Opgave " + task);
Console.WriteLine("=====================================");

// Input fuktion til at læse input og skrive besked i en
static string Input(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();
    return input ?? "";
}

static void Print(string message)
{
    Console.WriteLine(message);
}


// Csharp opgaver 1
if (task == "csharp1")
{
    String name = "Esben";
    int age = 17;
    double money = 1234.56;
    Console.WriteLine($"Jeg hedder {name}, er {age} år og har tjent {money} kr. på at lappe cykler.");
}

if (task == "csharp2")
{
    // Csharp opgaver 2
    double cake = 23.56;
    double beer = 34.67;
    double sausage = 65.34;
    double total = cake + beer + sausage;

    Console.WriteLine($"Kage\t{cake}\n" +
                      $"Øl\t{beer}\n" +
                      $"Pølse\t{sausage}\n" +
                      $"I alt\t{total}");
}

if (task == "csharp3")
{
    // Csharp opgaver 3
    string name = "";
    int age = 0;

    Console.WriteLine("indtast dit navn: ");
    string? inputName = Console.ReadLine();
    name = inputName ?? "";

    Console.WriteLine("Indtast din alder: ");
    string? inputAge = Console.ReadLine();
    age = Convert.ToInt32(inputAge ?? "0");

    Console.WriteLine($"Du hedder {name} og er {age} år gammel.");
}

if (task == "csharp4")
{
    // Csharp opgaver 4
    double n1 = 0;
    double n2 = 0;
    double n3 = 0;

    Console.WriteLine("Indtast tal 1: ");
    n1 = Convert.ToDouble(Console.ReadLine() ?? "0");

    Console.WriteLine("Indtast tal 2: ");
    n2 = Convert.ToDouble(Console.ReadLine() ?? "0");

    Console.WriteLine("Indtast tal 3: ");
    n3 = Convert.ToDouble(Console.ReadLine() ?? "0");

    double average = (n1 + n2 + n3) / 3;
    double sum = n1 + n2 + n3;

    Console.WriteLine($"Sum: {sum}\n" +
                      $"Gennemsnit: {average}");
}

if (task == "csharp5")
{
    // Csharp opgaver 5
    Console.WriteLine("indtast dit navn: ");
    string? inputName = Console.ReadLine();
    string name = inputName ?? "";

    Console.WriteLine("Indtast alder: ");
    string? inputAge = Console.ReadLine();
    int age = Convert.ToInt32(inputAge ?? "0");

    if (age > 57)
    {
        Console.WriteLine($"Hej {name}, du er for gammel.");
    }
    else
    {
        Console.WriteLine($"Hej {name}, du er ikke for gammel.");
    }
}

if (task == "ekstra6b")
{
    // Ekstraopgaver 6b
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("\n\n\n\n");
    Console.WriteLine("\t\t\tHello World!\t\t\t");
    Console.Write("\n\n\n\n");
}

if (task == "ekstra6c")
{
    // Ekstraopgaver 6c
    Console.WriteLine("\t * \t\n\t* *\t\n       *   *       \n      *** ***      \n       *   *      \n      *     *      \n     *       *     \n    ***********    \n");
    // Ingen farver på den her løsning
}

if (task == "ekstra10b")
{
    // Ekstraopgaver 10b
    double dist = Convert.ToDouble(Input("Indtast kørt afstand i km: "));
    double fuel = Convert.ToDouble(Input("Indtast forbrugt brændstof i L: "));
    double consumption = (fuel / dist) * 100;
    Console.WriteLine($"Brændstofforbrug: {consumption:F2} L/100km");
}

if (task == "ekstra11b")
{
    // Ekstraopgaver 11b
    double currentmoney = Convert.ToDouble(Input("Indtast kontosaldo: "));
    double interest = 1.0125;
    Console.WriteLine($"Saldo efter 1 år: {(currentmoney * interest).ToString("C"):F2}");
}

if (task == "ekstra16b")
{
    double income = Convert.ToDouble(Input("Indtast din indkomst: "));
    if (income < 42000)
    {
        Print("Du skal ikke betale skat.");
    }
    else if (income >= 42000 && income < 280000)
    {
        double tax = income * 0.3;
        Print($"Du skal betale {tax:C:F2} i skat. Det efterlader dig med {income - tax:C:F2}.");
    }
    else if (income >= 280000 && income < 390000)
    {
        double tax = income * 0.36;
        Print($"Du skal betale {tax:C:F2} i skat. Det efterlader dig med {income - tax:C:F2}.");
    }
        else if (income >= 390000)
    {
        double tax = income * 0.51;
        Print($"Du skal betale {tax:C:F2} i skat. Det efterlader dig med {income - tax:C:F2}.");
    }
}