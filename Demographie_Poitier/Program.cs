// See https://aka.ms/new-console-template for more information
double population = 87646;
int year = 2022;
while ( population < 100000)
{
    year++;
    population = population + (population * 0.89 / 100);
    
}

Console.WriteLine($"La population est de au moins 100k en {year}");
