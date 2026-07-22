namespace Lekcja3;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // string tekst = Console.ReadLine();
        // int liczba = int.Parse(Console.ReadLine());
        
        // Console.WriteLine($"Uzytkownik podał tekst {tekst} i liczbę {liczba}");

        int a = 3;
        int b = 2;
        int wynik = a + b;
        wynik = 1+2*b;
        Console.WriteLine("Wynik operacji: " + wynik);

        int dodawanie = a+b;
        int odejmowanie = a-b;
        int mnozenie = a*b;
        float dzielenie = a / b; //dzielenie całkowite
        Console.WriteLine("Dzielenie calkowite (3/2): " + dzielenie);


        //srednia ocen:
        int ocena1 = 3;
        int ocena2 = 4;
        int ocena3 = 1;

        // float srednia = (ocena1 + ocena2 + ocena3) / 3; //program wykona dzielenie calkowite - blad precyzji
        float srednia = (ocena1 + ocena2 + ocena3) / 3f; //program wykona dzielenie na liczbie zmiennoprzecinkowej
        Console.WriteLine(srednia);


        //Precyzja i rzutowanie
        int c  = 5;
        int d = 2;

        Console.WriteLine(c/d);
        Console.WriteLine((float)c/d); // rzutowanie - pomaga uniknąć błędów precyzji
        // Console.WriteLine(float.Parse(c/d)); -- błąd! - metoda Parse przyjmuje stringa

        // modulo daje nam reszte z dzielenia 
        int modulo = c % d; //1

        // 7 % 1 -> 0
        // 17 % 10 -> 7

        int uczniowie = 23;
        int cukierki = 60;

        int naUcznia = cukierki / uczniowie;
        float dokladnieNaUcznia = (float) cukierki / uczniowie;
        int reszta = cukierki % uczniowie;


        // metody biblioteki Math
        double potega = Math.Pow(2,3);
        Console.WriteLine("Potega (2^3) " + potega);

        Console.WriteLine("Zaokrąglenie liczb: ");
        double zaokraglanie;

        zaokraglanie = Math.Ceiling(3.14159);
        Console.WriteLine(zaokraglanie);

        zaokraglanie = Math.Floor(3.14159);
        Console.WriteLine(zaokraglanie);

        zaokraglanie = Math.Round(3.14159);
        Console.WriteLine(zaokraglanie);

        double bezw = Math.Abs(-5);
        Console.WriteLine(bezw);
    }
}