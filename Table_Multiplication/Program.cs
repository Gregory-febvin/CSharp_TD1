// See https://aka.ms/new-console-template for more information

Console.WriteLine("Entrer le chiffre de votre table");
try
{
    int table_number = int.Parse(Console.ReadLine());

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{i} * {table_number} = {i * table_number}\n");
    }
}
catch (Exception e)
{
    Console.WriteLine($"Erreur {e.Message}");
}