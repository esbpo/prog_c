int taskNumber = 6; // Skift til opgaven der skal køres
Console.WriteLine($"Opgave {taskNumber}");
Console.WriteLine("=====================================");

// Opgave 1
if (taskNumber == 1)
{
    String name = "Esben";
    int age = 17;
    double money = 1234.56;
    Console.WriteLine($"Jeg hedder {name}, er {age} år og har tjent {money} kr. på at lappe cykler.");
}

if (taskNumber == 2)
{
    // Opgave 2
    double cake = 23.56;
    double beer = 34.67;
    double sausage = 65.34;
    double total = cake + beer + sausage;

    Console.WriteLine($"Kage\t{cake}\n" +
                      $"Øl\t{beer}\n" +
                      $"Pølse\t{sausage}\n" +
                      $"I alt\t{total}");
}

if (taskNumber == 3)
{
    // Opgave 3
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

if (taskNumber == 4)
{
    // Opgave 4
    double n1 = 0;
    double n2 = 0;
    double n3 = 0;

    Console.WriteLine("Indtast tal 1: ");
    n1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Indtast tal 2: ");
    n2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Indtast tal 3: ");
    n3 = Convert.ToDouble(Console.ReadLine());

    double average = (n1 + n2 + n3) / 3;
    double sum = n1 + n2 + n3;

    Console.WriteLine($"Sum: {sum}\n" +
                      $"Gennemsnit: {average}");
}

if (taskNumber == 5)
{
    // Opgave 5
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

