namespace Lekcja12;

class Program
{
    static void Main(string[] args)
    {
        //#1 Zadanie 1 - Bohater gry:  Stwórz prosty program, 
        // w którym wykorzystując zmienne zdefiniujesz podstawowe informacje o bohaterze gry RPG, 
        // a następnie wypiszesz je na ekranie w formie spójnego komunikatu. 
        // Zdefiniuj: nick, maksymalny i aktualny pasek życia siłę, zręczność i inteligencję. 

        //Miejsce na dane bohatera:
        string nick = "ShadowFox";

        int currentHp = 90;
        int maxHp = 125;

        int strength = 15;
        int agility = 18;
        int intelligence = 10;

        // Wyświetlenie informacji: (usuń znacznik komentarza po podaniu danych wyżej)
        // Console.WriteLine("=== KARTA POSTACI RPG ===");
        // Console.WriteLine($"Nick: {nick}");
        // Console.WriteLine($"Życie: {currentHp} / {maxHp}");
        // Console.WriteLine($"Siła: {strength}");
        // Console.WriteLine($"Zręczność: {agility}");
        // Console.WriteLine($"Inteligencja: {intelligence}");

        //#2 Składnia metod:


        // static void Main()
        // {
        // //wywołanie własnej metody
        // NazwaWCzasowniku();
        // }


        // //Własna metoda
        // static void NazwaWCzasowniku()
        // {
        // //kod
        // }



        // #3 Przekazywanie argumentów do metod
        Math.Pow(3, 5);



        // #4 Zadanie 2 - Bohaterowie gry:  
        // Zmodyfikuj stworzony wcześniej program, aby wykorzystywał metodę do tworzenia bohatera, 
        // a następnie stwórz dwóch nowych bohaterów. 

        CharacterInfo("ShadowFox", 90, maxHp, 20, 50);
        CharacterInfo("IronSword", 50, 100, 25, 40);


        // #5 Zwracanie danych przez metody



      
        // #6 Zadanie 3 - Bohaterowie gry i ich moc magiczna:  
        // Zmodyfikuj stworzony wcześniej program dodając bohaterom manę. 
        // Wynik procentowy hp i many obliczaj metodą.  





        // #7 Przeciążanie metod:

        Attack();


        // #8 Zadanie 4 - Atakowanie wroga:  
        // Napisz prosty symulator atakowania wroga z wykorzystaniem różnych ataków. 
        // Stwórz przynajmniej 3 typy ataków. 
        
        // Dodatkowe: Skorzystaj z Enum do rozróżnienia typów jednostek.  
        // Dodatkowe: Popraw czytelność kodu tworząc metody pomocnicze.


        int num = LiczbaSzesc();
        Console.WriteLine(num);

    }

    // static void CharacterInfo()
    // {
    //     Console.WriteLine("superbohater");
    // }

    static void CharacterInfo(string nick, int currentHp, int maxHp, int currentMana, int maxMana)
    {
        Console.WriteLine($"Nazywam się {nick} i jestem graczem gry RPG");

        double hpPercent = (double) currentHp * 100 / maxHp;
        Console.WriteLine("Życie: " + GetPercent(currentHp, maxHp) + "%");
        Console.WriteLine("Mana: "  + GetPercent(currentMana, maxMana) + "%");

        // Console.WriteLine($"Mam {(int)hpPercent}% życia");
        // Console.WriteLine($"Statystyki: Siła = {strength}");
    }
    static int GetPercent(int current, int max)
    {
        int percent = current * 100 / max;
        return percent;
    }

    //Całość składni: 
    // [Modyfikatory] Typ Nazwa ( [Lista argumentów] )
    // {
        // [Ciało metody]
        // kod
        // return dane w zwracanym typie

    // }


    static string PodajNick()
    {
        return "";
    }

    static void Attack()
    {
        Console.WriteLine("Atak podstawowy");
    }

    static void Attack(string nick)
    {
        Console.WriteLine($"Atak przeprowadzony przez {nick}");
        
    }

    static string Attack(int strength)
    {
        return "Atak wzmocniony z siłą " + strength;
    }

    static void Attack(int mana, string attackName)
    {
        Console.WriteLine("Atak kulą ognia");
        
    }


    static int LiczbaSzesc()
    {      
        return 6;
    }


}
