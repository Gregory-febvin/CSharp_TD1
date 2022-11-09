// See https://aka.ms/new-console-template for more information
while (true)
{
    Console.WriteLine("Saisir un age compris entre 6 et 14 ans");
    int age = int.Parse(Console.ReadLine());

    if ( age > 14 || age < 6)
    {
        Console.WriteLine("Age invalide");
    }
    else
    {
        if(age >= 6 && age <= 7)
        {
            Console.WriteLine("Poussin");
        }else if(age >= 8 && age <= 9)
        {
            Console.WriteLine("Pupille");
        }else if(age >= 10 && age <= 11)
        {
            Console.WriteLine("Mimine");
        }else if(age >= 12 && age <= 14)
        {
            Console.WriteLine("Cadet");
        }
    }
}
