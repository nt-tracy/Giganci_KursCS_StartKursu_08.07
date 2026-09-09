namespace Lekcja10;

class Program
{
    static void Main(string[] args)
    {
        //#1 Zadanie rozgrzewkowe: 
        // Stwórz program, który za pomocą pętli wyświetli 7 kolejnych potęg liczby 2.
        // (skorzystaj z odpowiedniej pętli i zmiennej przechowującej aktualną liczbę)

        int wynik = 1;
        for (int i=0; i<7; i++)
        {
            wynik *= 2;
            Console.WriteLine(wynik);
        }

        //#2 Poznajemy działanie tablic:
        //składnia: typ[] nazwaTablicy = {elementy po przecinku}
        int[] liczby = {1, 2, 3, 4};

        //dostęp do elementów:
        Console.WriteLine(liczby[0]);
        Console.WriteLine(liczby[2]);

        //System.IndexOutOfRangeException
        // Console.WriteLine(liczby[4]);


        //#3 Typy danych w tablicach:
        // int, string, bool, char (jedna litera), float


        //#4 Zadanie 1: 
        // Korzystając z poznanych informacji o tablicach spróbuj stworzyć tablicę napisów, 
        // która będzie zawierała twoje ulubione gry, filmy lub postaci.
        string[] gry = {"Minecraft", "Roblox", "AngelsOfDeath"};
        
        //#5 Dynamiczne tworzenie tablic - new typ[rozmiar] 
        // domyślne wartości dla int[] - 0
        // domyślne wartości dla string[] -

        int[] liczby2 = new int[5]; 
        // typ[] nazwaTablicy = new typ[rozmiar tablicy]
        Console.WriteLine(liczby2[2]);

        string[] slowa = new string[5];
        Console.WriteLine("słowo: " + slowa[2]);

        //#6 Odczytywanie rozmiaru tablicy - Length
        Console.WriteLine("Podaj rozmiar tablicy: ");
        int rozmiar = int.Parse(Console.ReadLine());
        int[] noweLiczby = new int[rozmiar];
        Console.WriteLine($"Rozmiar tablicy: {noweLiczby.Length} "); 

        for(int i=0; i < gry.Length; i++)
        {
            Console.WriteLine(gry[i]);
        }

        //w C# rozmiar tablicy jest stały

        //#7 Zadanie 2: 
        // Wróć do zadania rozgrzewkowego (z potęgami). 
        // Spróbuj umieścić wyniki w tablicy.

        int wynik7 = 1;
        int[] potegi = new int[7];
        for (int i = 0; i < potegi.Length; i++)
        {
            wynik7 *= 2;
            //Console.WriteLine(wynik7);
            potegi[i] = wynik7;
            Console.WriteLine(potegi[i]);

        }


        //#8 String jako tablica?
        Console.WriteLine("Podaj tekst: ");
        string napis = Console.ReadLine();

        Console.WriteLine($"Długość napisu: {napis.Length}");
        Console.WriteLine("Przeliteruję: ");

        for(int i=0; i<napis.Length; i++)
        {
            Console.Write(napis[i] + " ");
        }

        Console.WriteLine($"Typ danych w napisie: {napis[0].GetType()}");

        //Zadanie dodatkowe: Utwórz tablicę 12 losowych liczb
        //Zadanie dodatkowe 2: Oblicz sumę elementów w tablicy

    }
}
