// See https://aka.ms/new-console-template for more information


using System;

// Genero un Array di cibi preferiti

string[] cibiPreferiti = { "Sushi", "Pizza", "Gelato", "Mango", "Pesce", "Patate" , "Melanzane" };

// lunghezza della classifica dei cibi preferiti

Console.WriteLine($"La lunghezza della classifica è: {cibiPreferiti.Length}");


// classifica dei miei piatti preferiti

Console.WriteLine("La classifica dei miei piatti preferiti è: ");

for (int i = 0; i < cibiPreferiti.Length; i++)
{
    var numClassifica = i + 1;
    Console.WriteLine($"{numClassifica} ° {cibiPreferiti[i]}");
}


// Il mio cibo preferito

Console.WriteLine($"Il mio cibo preferito è: {cibiPreferiti[0]}");

// Il mio cibo preferito ma non troppo 

Console.WriteLine($"Il mio cibo preferito ma non troppo é: {cibiPreferiti[cibiPreferiti.Length - 1]}");



// BONUS

// Trovo l'elemento centrale della classifica

var centroClassifica = cibiPreferiti.Length / 2;


if (centroClassifica % 2 == 0)
{
    Console.WriteLine($"I cibi a mezza classifica sono: {cibiPreferiti[centroClassifica - 1]}  e  {cibiPreferiti[centroClassifica]}"); // sono i due elementi centrali della mia classifica
}
else
{
    Console.WriteLine($"Il cibo di mezza classifica è:  {cibiPreferiti[centroClassifica]}"); // è l'unico elemento centrale della mia classifica
}
