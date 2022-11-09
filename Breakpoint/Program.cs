int n;
int factorielle = 1;

Console.WriteLine("Entrez un entier > 0");
n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++) 
{ 
    factorielle = factorielle * i;
    
}
Console.WriteLine($"La factorielle de {n} vaut {factorielle}");