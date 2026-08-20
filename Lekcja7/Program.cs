namespace Lekcja7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Powiedzonko");
        Console.WriteLine("2. Informacja dnia");
        Console.WriteLine("3. ASCII-art");
        Console.WriteLine("4. Ciekawy fakt");


        int wybor = int.Parse(Console.ReadLine());

        if (wybor == 1)
        {
            Console.WriteLine("Dobra robota, młody programisto!");
        }
        else if (wybor == 2)
        {
            Console.WriteLine("Dziś jest świetny dzień na naukę C#!");
        }
        else if (wybor == 3)
        {
            Console.WriteLine("(^_^)");
        }
        else if (wybor == 4)
        {
            Console.WriteLine("Fakt: komputery KOCHAJĄ instrukcje warunkowe!");
        }
        else
        {
            Console.WriteLine("Błędny wybór");
        }

        

        string cmd = Console.ReadLine();
        // instrukcja switch 
        switch (cmd)
        {
            case "jeden":
            case "Jeden":
            // case "Trzy":
                Console.WriteLine("Dobra robota, młody programisto!");
                break;
            case "dwa":
                Console.WriteLine("Dziś jest świetny dzień na naukę C#!");
                break;
            default:
                Console.WriteLine("nie znam takiej opcji");
                break;
        }


        // if - jeśli / jeżeli
        // else - inaczej, w przeciwnym razie 
        // switch - przełącz
        // case - przypadek
        // int - integer - liczba całkowita
        // char - character - znak
        // string - "ciąg / łańcuch" - tekst

        // ENUM - typ wyliczeniowy 
        // kierunki świata
        Direction firstDirection = Direction.North;
        Console.WriteLine(firstDirection);

        // korzystamy z profesji
        Profesja gracz1 = Profesja.Kowal;
        Profesja gracz2 = Profesja.Mag;

        Console.WriteLine(gracz1 + " " + gracz2);

        Profesja player = Profesja.Mag;

        switch (player)
        {
            case Profesja.Mag:
                Console.WriteLine("Mag rzuca zaklęcia");
                break;
            case Profesja.Rycerz:
                Console.WriteLine("Rycerz walczy mieczem");
                break;
            default:
                Console.WriteLine("Nie ma takiej profesji");
                break;
        }

        Profesja player2 = Profesja.Rycerz;
        Console.WriteLine((int)player2);

    }
}

enum Direction
{
    North,
    South,
    East,
    West
}

enum Profesja
{
    // wszystkie istniejące profesje 
    Mag, //0
    Rycerz, //1 ...
    Kowal,
    Druid,
    Paladyn
}
