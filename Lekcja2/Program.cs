namespace Lekcja2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //typ nazwaZmiennej = wartosc
        string nazwa = "Jajecznica"; //typ tekstowy
        int czas = 5; //typ liczb całkowitych
        int wielkosc = 9;
        float waga = 300.0f; //typ liczb zmiennoprzecinkowych

        //konkatenacja
        Console.WriteLine("Produkt utworzony to " + nazwa + ", przyotowanie trwa " + czas + " min");

        //interpolacja
        Console.WriteLine($"Produkt utworzony to {nazwa}, przyotowanie trwa {czas} min");

        //indeksowanie
        Console.WriteLine("Produkt utworzony to {0}, przyotowanie trwa {1} min", nazwa, czas);

        //parsowanie
        Console.WriteLine("Podaj imię: ");
        string imie = Console.ReadLine();

        Console.WriteLine("Podaj wiek ");
        int wiek2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj wagę");
        float waga2 = float.Parse(Console.ReadLine()); //float na konsoli wczytujemy z przecinkiem, np. 5,5

        Console.WriteLine("Podaj pesel - 11 cyfr");
        // int pesel = int.Parse(Console.ReadLine()); //błąd! int to za mało na pesel
        long pesel = long.Parse(Console.ReadLine());

        //pesel można też przechowywać w stringu
        string pesel2 = Console.ReadLine();
    }
}
