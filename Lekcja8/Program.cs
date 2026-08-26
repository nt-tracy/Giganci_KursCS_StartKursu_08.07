namespace Lekcja8;

class Program
{
    static void Main(string[] args)
    {        


        //Zadanie 1 - tłumacz
        //F5 - Continue - kolejny breakpoint   
        Console.WriteLine("Podaj slowo:  ");
        string word = Console.ReadLine().ToLower();

        //switch
        switch (word)
        {
            case "kot":
            case "cat":
                Console.WriteLine("kot - cat");
                break;
            case "pies":
            case "dog":
                Console.WriteLine("pies - dog");
                break;
            default:
                Console.WriteLine("Slowo nieznane w slowniku");
                break;
        }

        //Zadanie 2 - kalkulator wykorzystujący funkcje z biblioteki Math
        Console.WriteLine("Podaj wartość:");
        int liczba = int.Parse(Console.ReadLine());
        Console.WriteLine("Wybierz operację: \n1. Potęga \n2. Logarytm \n3. Pierwiastek \n4. Silnia");
        int operacja = int.Parse(Console.ReadLine());
        double wynik = 0;
        switch (operacja)
        {
            case 1:
                wynik = Math.Pow(liczba, liczba);
                break;
            case 2:
                wynik = Math.Log(liczba);
                break;
            case 3:
                wynik = Math.Sqrt(liczba);
                break;
            case 4:
                wynik = Silnia(liczba);
                break;
            default:
                Console.WriteLine("Nieprawidłowa operacja");
                return;
        }
        Console.WriteLine("Wynik = " + Math.Round(wynik,2));



    }


    //Funkcja (metoda) Silnia
    static double Silnia(int liczba)
    {
        double silnia = liczba;
        for(int i=1; i <liczba; i++)
        {
            silnia *= i;
        }
        return silnia;
    }



}
