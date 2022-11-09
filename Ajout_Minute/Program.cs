// See https://aka.ms/new-console-template for more information
using System;
using System.Data;
using System.Diagnostics.Metrics;

int heure, minute;
Console.WriteLine("Donne moi l'heure actuelle");
string value_heure = Console.ReadLine();
heure = int.Parse(value_heure);

Console.WriteLine("Donne moi les minutes");
string value_minute = Console.ReadLine();
minute = int.Parse(value_minute);

if (minute == 59 & heure != 23 )
{
    minute = 0;
    heure = ++heure;
    Console.WriteLine($"Il est {heure} h {minute}");
}else if (heure == 23 & minute == 59)
{
    minute = 0;
    heure = 0;
    Console.WriteLine($"Il est {heure} h {minute}");
}else
{
    minute = ++minute;
    Console.WriteLine($"Il est {heure} h {minute}");
}