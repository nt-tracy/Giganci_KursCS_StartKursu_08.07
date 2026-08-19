using System.Reflection.Emit;

namespace Lekcja6;

class Program
{
    static void Main(string[] args)
    {

        //zadanie 1
        string poprawneHaslo = "masło";

        Console.WriteLine("Podaj haslo: ");
        string podaneHaslo = Console.ReadLine();
        // == - operator porównania
        bool czyPoprawne = poprawneHaslo == podaneHaslo;

        if(czyPoprawne)
        // if (poprawneHaslo == podaneHaslo)
        {
            Console.WriteLine("Zalogowano!");
        }
        else
        {
            Console.WriteLine("Zle haslo :<");
        }

        // if (poprawneHaslo == "masło")
        // {
        //     Console.WriteLine("Poprawne");
        // }

        //zadanie 2
        // czerwony pasek - od średniej 4,75
        // Console.WriteLine("Podaj srednia: ");
        // float average = float.Parse(Console.ReadLine());

        // Console.WriteLine("Podaj ocene z zachowania: ");
        // int behavior = int.Parse(Console.ReadLine());

        // if ( average >= 4.75 || behavior >= 4 )
        //     Console.WriteLine("Czerwony pasek");
        // else
        //     Console.WriteLine("Brak czerwonego paska");


        //menu wyboru

        // Console.WriteLine("1. ASCII-art");
        // Console.WriteLine("2. Fajny fakt");

        // int choice = int.Parse(Console.ReadLine());

        // if (choice == 1)
        //     Console.WriteLine("(^_^)");
        // else if (choice == 2)
        //     Console.WriteLine("Uczenie się C# jest fajne");
        // else 
        //     Console.WriteLine("Nie przewidziano odpowiedzi");
            

        // Console.WriteLine("Podaj numer dnia tygodnia: ");
        // int number = int.Parse(Console.ReadLine());

        // if (number == 1)
        //     Console.WriteLine("poniedzialek");
        // else if (number == 2)
        //     Console.WriteLine("wtorek");
        // else 
        //     Console.WriteLine("To be continued...");

        // klasa.metoda()
        // klasy, które używaliśmy do tej pory - Console, Math
        // Random - klasa 
        //tworzymy obiekt
        Random generator = new Random();

        Console.WriteLine(generator.Next(100));
        Console.WriteLine(generator.Next(10, 51));


        // string, a wartości logiczne
        // porównywanie wartości: ==, !=
        // string.Contains() oraz string.Length() 

        string napis = "Testowe zdanie dla sprawdzenia metod Contains() i Length()";
        Console.WriteLine($"Długość tekstu: {napis.Length}");
        Console.WriteLine(napis.Contains("Test"));
        if(napis.Contains("Test"))
        {
            Console.WriteLine("Napis zawiera słowo: Test");
        }



    }
}
