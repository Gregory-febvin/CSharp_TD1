// See https://aka.ms/new-console-template for more information
float a, b, c, s;
double A;


Console.WriteLine("Entrer a");
a = float.Parse(Console.ReadLine());

Console.WriteLine("Entrer b");
b = float.Parse(Console.ReadLine());

Console.WriteLine("Entrer c");
c = float.Parse(Console.ReadLine());

if (a+b >= c)
{
    s = (a + b + c) / 2;
    float number_Racine = s * (s - a) * (s - b) * (s - c);
    A = Math.Sqrt(number_Racine);

    Console.WriteLine($"L'aire A du triangle est {A}");
}
else
{
    Console.WriteLine("Le triangle n'est pas valide");
}