﻿// See https://aka.ms/new-console-template for more information
//rakendus kusib kasutajalt valida oma sugu (m/f)
//rakendus kusib kasutajalt sisestada tema perekonnanime
//lahtudes kasutaja valikust, rakendus tervitab kasutajat jargmiselt:
//"welcome, Mr [kasutaja perekonnanimi] / "Welcome, Ms [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender(m/f)");


char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string formaadis
Console.WriteLine("Please enter your last name");

string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome , Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome {userLastName}!");
}
