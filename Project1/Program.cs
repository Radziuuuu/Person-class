using System;
using Project1;

class Program
{
    static void Main()
    {
        Osoba osoba1 = new Osoba("Jan", "Kowalski", 'M', new DateTime(1990, 5, 15));

        // Wyświetlanie informacji
        Console.WriteLine("Informacje o osobie:");
        Console.WriteLine($"Imię: {osoba1.Imie}");
        Console.WriteLine($"Nazwisko: {osoba1.Nazwisko}");
        Console.WriteLine($"Płeć: {osoba1.Plec}");
        Console.WriteLine($"Data urodzenia: {osoba1.DataUrodzenia.ToShortDateString()}");

        osoba1.Imie = "Anna";
        osoba1.Nazwisko = "Nowak";
        osoba1.Plec = 'K';
        osoba1.DataUrodzenia = new DateTime(1985, 10, 20);

        // Ponowne wyświetlanie zaktualizowanych informacji
        Console.WriteLine("\nZaktualizowane informacje o osobie:");
        Console.WriteLine($"Imię: {osoba1.Imie}");
        Console.WriteLine($"Nazwisko: {osoba1.Nazwisko}");
        Console.WriteLine($"Płeć: {osoba1.Plec}");
        Console.WriteLine($"Data urodzenia: {osoba1.DataUrodzenia.ToShortDateString()}");

        Console.ReadKey();
    }
}
