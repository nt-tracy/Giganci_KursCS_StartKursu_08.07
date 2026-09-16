namespace Lekcja11_SkillCheck;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== WYBIERZ ZADANIE ===");
            Console.WriteLine("1-14: Uruchom wybrane zadanie");
            Console.WriteLine("0: Wyjście z programu");
            Console.Write("\nTwój wybór: ");

            string input = Console.ReadLine() ?? "";

            if (input == "0")
            {
                Console.WriteLine("Koniec programu.");
                break;
            }

            Console.WriteLine();

            switch (input)
            {
                case "1":  Zadanie1();  break;
                case "2":  Zadanie2();  break;
                case "3":  Zadanie3();  break;
                case "4":  Zadanie4();  break;
                case "5":  Zadanie5();  break;
                case "6":  Zadanie6();  break;
                case "7":  Zadanie7();  break;
                case "8":  Zadanie8();  break;
                case "9":  Zadanie9();  break;
                case "10": Zadanie10(); break;
                case "11": Zadanie11(); break;
                case "12": Zadanie12(); break;
                case "13": Zadanie13(); break;
                case "14": Zadanie14(); break;
                default:
                    Console.WriteLine("Niepoprawny numer zadania!");
                    break;
            }

            Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu wyboru zadań...");
            Console.ReadKey();
        }
    }

    static void Zadanie1()
    {
        Console.Write("Podaj imię: ");
        string name = Console.ReadLine() ?? "";

        Console.Write("Podaj wiek: ");
        string ageText = Console.ReadLine() ?? "0";
        int age = int.Parse(ageText);

        Console.WriteLine("Cześć " + name + "!");
        Console.WriteLine($"Masz {age} lat.");
        Console.WriteLine($"Twoje imię ma {name.Length} znaków.");
    }

    static void Zadanie2()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double a = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Podaj drugą liczbę: ");
        double b = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine($"Suma: {a + b}");
        Console.WriteLine($"Różnica: {a - b}");
        Console.WriteLine($"Iloczyn: {a * b}");

        if (b == 0)
        {
            Console.WriteLine("Iloraz: nie można dzielić przez 0!");
        }
        else
        {
            Console.WriteLine($"Iloraz: {a / b}");
        }
    }

    static void Zadanie3()
    {
        Console.Write("Podaj wiek: ");
        int age = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Czy masz opiekuna? (tak/nie): ");
        string guardianText = (Console.ReadLine() ?? "").Trim().ToLower();
        bool hasGuardian = guardianText == "tak" || guardianText == "t";

        bool canEnter = age >= 16 || hasGuardian;

        Console.WriteLine($"Wynik: {(canEnter ? "Możesz wejść" : "Nie możesz wejść")}");
        Console.WriteLine($"(age>=16={age >= 16}, hasGuardian={hasGuardian})");
    }

    static void Zadanie4()
    {
        Console.Write("Podaj temperaturę (°C): ");
        double t = double.Parse(Console.ReadLine() ?? "0");

        if (t < -10) Console.WriteLine("Ekstremalnie zimno! Uwaga.");
        else if (t < 5) Console.WriteLine("Zimno.");
        else if (t < 20) Console.WriteLine("OK.");
        else if (t < 30) Console.WriteLine("Ciepło.");
        else Console.WriteLine("Upał! Pij wodę.");

        if (t > 35) Console.WriteLine("Ostrzeżenie: bardzo wysoka temperatura!");
    }

    static void Zadanie5()
    {
        Console.Write("Podaj długość hasła (8–20): ");
        int length = int.Parse(Console.ReadLine() ?? "8");

        if (length < 8) length = 8;
        if (length > 20) length = 20;

        string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string digits = "0123456789";
        string allChars = letters + digits;

        Random random = new Random();
        string password = "";

        int digitPosition = random.Next(0, length);

        for (int i = 0; i < length; i++)
        {
            char nextChar;

            if (i == digitPosition)
            {
                int index = random.Next(0, digits.Length);
                nextChar = digits[index];
            }
            else
            {
                int index = random.Next(0, allChars.Length);
                nextChar = allChars[index];
            }

            password += nextChar;
        }

        Console.WriteLine($"Wygenerowane hasło: {password}");
    }

    static void Zadanie6()
    {
        var rng = new Random();
        int secret = rng.Next(1, 101);
        int tries = 0;
        int maxTries = 7;

        Console.WriteLine("Zgadnij liczbę 1-100. Masz 7 prób.");

        while (tries < maxTries)
        {
            Console.Write("Strzał: ");
            int guess = int.Parse(Console.ReadLine() ?? "0");
            tries++;

            if (guess == secret)
            {
                Console.WriteLine($"Brawo! Zgadłeś w {tries} próbach.");
                return;
            }

            Console.WriteLine(guess < secret ? "Za mało." : "Za dużo.");
        }

        Console.WriteLine($"Koniec prób. Liczba to: {secret}");
    }

    static void Zadanie7()
    {
        Console.Write("Wpisz zdanie: ");
        string text = Console.ReadLine() ?? "";
        string lower = text.ToLower();

        bool hasKot = lower.Contains("kot");
        bool hasPies = lower.Contains("pies");
        bool hasAI = lower.Contains("ai");

        Console.WriteLine($"Zawiera 'kot': {hasKot}");
        Console.WriteLine($"Zawiera 'pies': {hasPies}");
        Console.WriteLine($"Zawiera 'AI': {hasAI}");

        Console.WriteLine($"Długość zdania: {text.Length}");
        Console.WriteLine(text.Length < 20 ? "Zdanie krótkie." : "Zdanie długie.");
    }

    static void Zadanie8()
    {
        Console.WriteLine("Tajną wiadomością jest “CZYTAJ HISTORIĘ PLIKU NA GITHUBIE UWAŻNIE!”. Niekonsekwencją jest nieprawidłowa nazwa zmiany 4, ponieważ tytuł został dodany do opisu.");
    }

    static void Zadanie9()
    {
        Random rng = new Random();

        Console.Write("Podaj nick gracza: ");
        string nick = Console.ReadLine() ?? "Gracz";

        int playCount = 0;
        bool running = true;

        string[] startMessages =
        {
            "Powodzenia, {0}!",
            "Witamy w arenie kodu, {0}!",
            "{0}, czas na grę!",
            "Startujemy! {0} – pokaż moc!"
        };

        while (running)
        {
            Console.WriteLine("\n=== 🎮 MENU GRY ===");
            Console.WriteLine("1) Graj");
            Console.WriteLine("2) Opcje");
            Console.WriteLine("3) Autorzy");
            Console.WriteLine("4) Wyjście");
            Console.Write("Wybierz opcję: ");

            string choice = (Console.ReadLine() ?? "").Trim();

            switch (choice)
            {
                case "1":
                    playCount++;
                    string msgTemplate = startMessages[rng.Next(0, startMessages.Length)];
                    Console.WriteLine("\n🎯 " + string.Format(msgTemplate, nick));
                    Console.WriteLine($"Licznik uruchomień gry: {playCount}");
                    Console.WriteLine("Naciśnij ENTER, aby wrócić do menu...");
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("\n⚙️ Opcje:");
                    Console.WriteLine("Dźwięk: Włączony");
                    Console.WriteLine("Poziom trudności: Normalny");
                    Console.WriteLine("Naciśnij ENTER, aby wrócić do menu...");
                    Console.ReadLine();
                    break;

                case "3":
                    Console.WriteLine("\n👨‍💻 Autorzy:");
                    Console.WriteLine("Projekt edukacyjny C#");
                    Console.WriteLine("Autor: Uczeń");
                    Console.WriteLine("Naciśnij ENTER, aby wrócić do menu...");
                    Console.ReadLine();
                    break;

                case "4":
                    Console.WriteLine("\nZamykanie gry...");
                    running = false;
                    break;

                default:
                    Console.WriteLine("\n❌ Nieprawidłowy wybór!");
                    break;
            }
        }

    }

    static void Zadanie10()
    {
        Console.WriteLine("Wybierz trudność: 1=Easy, 2=Normal, 3=Hard");
        Console.Write("Twój wybór: ");

        int pick = int.Parse(Console.ReadLine() ?? "1");

        if (pick < 1 || pick > 3)
        {
            Console.WriteLine("Niepoprawny wybór! Ustawiam Easy.");
            pick = 1;
        }

        Difficulty diff = (Difficulty)pick;

        int max = diff switch
        {
            Difficulty.Easy => 20,
            Difficulty.Normal => 50,
            Difficulty.Hard => 100,
            _ => 20
        };

        Console.WriteLine($"Wybrano: {diff}");
        Console.WriteLine($"Zakres losowania w grze: 1–{max}");
    }

    static void Zadanie11()
    {
        float f = 0.1f + 0.2f;
        double d = 0.1 + 0.2;
        decimal m = 0.1m + 0.2m;

        Console.WriteLine($"float: 0.1 + 0.2 = {f}");
        Console.WriteLine($"double: 0.1 + 0.2 = {d}");
        Console.WriteLine($"decimal: 0.1 + 0.2 = {m}");
    }

    static void Zadanie12()
    {
        Console.Write("Podaj pierwszą liczbę (a): ");
        double a = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Podaj drugą liczbę (b): ");
        double b = double.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("\n=== OBLICZENIA PODSTAWOWE ===");

        double aPowB = Math.Pow(a, b);
        double bPowA = Math.Pow(b, a);

        Console.WriteLine($"a^b = {aPowB}");
        Console.WriteLine($"b^a = {bPowA}");

        if (a >= 0)
            Console.WriteLine($"sqrt(a) = {Math.Sqrt(a)}");
        else
            Console.WriteLine("Nie można pierwiastkować liczby ujemnej (a).");

        if (b >= 0)
            Console.WriteLine($"sqrt(b) = {Math.Sqrt(b)}");
        else
            Console.WriteLine("Nie można pierwiastkować liczby ujemnej (b).");

        double max = Math.Max(a, b);
        double min = Math.Min(a, b);

        Console.WriteLine($"Większa liczba: {max}");
        Console.WriteLine($"Mniejsza liczba: {min}");

        Console.WriteLine("\n=== POLA FIGUR (DODATKOWE) ===");

        double squareArea = a * a;
        Console.WriteLine($"Pole kwadratu (bok = a): {squareArea}");

        double rectangleArea = a * b;
        Console.WriteLine($"Pole prostokąta (a x b): {rectangleArea}");

        double triangleArea = (a * b) / 2.0;
        Console.WriteLine($"Pole trójkąta (a i b): {triangleArea}");

        if (b >= 0)
        {
            double circleArea = Math.PI * b * b;
            Console.WriteLine($"Pole koła (r = b): {circleArea}");
        }
        else
        {
            Console.WriteLine("Nie można obliczyć pola koła dla ujemnego promienia.");
        }
    }

    static void Zadanie13()
    {
        int[] grades = new int[5];

        for (int i = 0; i < grades.Length; i++)
        {
            Console.Write($"Podaj ocenę #{i + 1}: ");
            grades[i] = int.Parse(Console.ReadLine() ?? "0");
        }

        int sum = 0;
        int max = grades[0];

        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
            if (grades[i] > max) max = grades[i];
        }

        double avg = (double)sum / grades.Length;

        Console.WriteLine($"Średnia: {avg:F2}");
        Console.WriteLine($"Najwyższa ocena: {max}");
        Console.WriteLine(avg >= 4.5 && max == 6 ? "Stypendium: TAK" : "Stypendium: NIE");
    }

    static void Zadanie14()
    {
        Console.Write("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        if (n <= 0)
        {
            Console.WriteLine("Liczba n musi być większa od 0.");
            return;
        }

        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        double avg = (double)sum / n;

        Console.WriteLine("Suma: " + sum);
        Console.WriteLine("Średnia: " + avg);
    }
}

enum Difficulty
{
    Easy = 1,
    Normal = 2,
    Hard = 3
}