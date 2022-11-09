// See https://aka.ms/new-console-template for more information
int age;
Console.WriteLine("Donne moi ton age\n");
string value = Console.ReadLine();
age = int.Parse(value);

if(age < 18)
{
    Console.WriteLine("Tu est mineur");
}
else
{
    Console.WriteLine("Tu est majeur");
}