namespace Lekcja1;

class Program
{
    static void Main(string[] args)
    {
        //komentarz jednolinijkowy

        /*
            jedna linia
            druga linia
            etc...
        
        */

        /*
            Python - #
            SQL --
        */

        // {
        //     Console.WriteLine("Cześć!");
        // }

        //imiona
        // Console.WriteLine("Cześć jestem GigaCzat, jak masz na imię?");
        Console.Write("Jak masz na imię? \n");
        string imie = Console.ReadLine();
        Console.WriteLine("Witaj " + imie);

        //pogoda
        Console.WriteLine("Jaka u Ciebie dzisiaj pogoda?");
        string pogoda = Console.ReadLine();
        Console.WriteLine("Strona internetowa też mi mówi, że pogoda to " + pogoda);

        //gra
        Console.WriteLine("Jaka jest Twoja ulubiona gra?");
        string gra = Console.ReadLine();
        Console.WriteLine(gra + " - to super gra!");

        //Console.Clear() - czyści cały ekran terminala

        /* Console.Write() / Console.WriteLine() 
        - różnią się tym, czy na końcu linii mamy dodany znak nowej linii (enter)
        - Console.WriteLine() ma znak nowej linii
        - Console.Write() nie dodaje znaku nowej linii na końcu 
        */
    }
}
 