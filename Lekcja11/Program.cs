namespace Lekcja11;

using System;

class Program
{

    // porównujemy liczby - ten sam typ  - ==
    // NIE MA THEN

    static void Main()
    {
        // zadanie 5 jest poniżej
        Console.WriteLine("Podaj jakąś liczbę.");
        var length = int.Parse(Console.ReadLine());
        var random = new Random();

        for (int i = 0; i < length; i++)
        {   
            int number = random.Next(0, 10);
            Console.Write(number);
        }
        
        
        //zadanie 6 jest poniżej
        var random2 = new Random();

        int mineNumber = random.Next(1, 101);
        int tryLimit = 5;

        Console.WriteLine("Zgadnij liczbę! Masz " + tryLimit + " prób!");

        for (int i = 0; i < tryLimit; i++)
        {
            int guess = int.Parse(Console.ReadLine());

            if (guess > mineNumber)
            {
                Console.WriteLine("Za dużo!");
            }
            else if (guess < mineNumber)
                {
                Console.WriteLine("Za mało!");
                }
                else
                {
                Console.WriteLine("Wygrałeś! 🎉");
                return;
            }
            }

            Console.WriteLine("Przegrałeś! Liczba to była " + mineNumber + ".");
            }
       
}


       