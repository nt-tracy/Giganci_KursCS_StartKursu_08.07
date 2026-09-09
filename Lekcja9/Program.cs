namespace Lekcja9;

class Program
{
    static void Main(string[] args)
    {
        // string poprawne = "123";

        // Console.WriteLine("Podaj hasło: ");
        // string podane = Console.ReadLine();

        // if (podane == poprawne) 
        //     Console.WriteLine("Zalogowano");
        // else 
        //     Console.WriteLine("Złe hasło");


        //while 
        // while (warunek)
        //{
        //}


        // while (poprawne != podane)
        // {
        //     Console.WriteLine("Podano złe hasło, spróbuj ponownie");
        //     Console.WriteLine("Podaj hasło: ");
        //     podane = Console.ReadLine();
        // }

        // Console.WriteLine("Zalogowano");

        // while (...);

        // int pozycja = 0;
        // Random r = new Random();

        // while (pozycja < 32)
        // {
        //     Console.WriteLine("Stoisz na pozycji " + pozycja);
        //     Console.WriteLine("Naciśnij enter, aby rzucić kością");
        //     Console.ReadLine();

        //     int rzut = r.Next(1,7);
        //     pozycja += rzut;
        //     Console.WriteLine($"Idziesz {rzut} do przodu");

        // }
        // Console.WriteLine("Doszedłeś do celu");



        //for(){}

        //for(odkąd; dokąd; co ma się dziać)

        // for (int i=10; i>0; i--)
        // {
        //     Console.WriteLine(i);
        // }



        while(true)
        {
            Console.Write("Podaj wiadomość: ");
            string msg = Console.ReadLine();
            
            if(msg == "koniec")
                continue;
                
            Console.WriteLine($"Wiadomość: {msg}");
        }


        // for(int i=1; i < 20; i++)
        // {
        //     if(i > 7)
        //         continue;
        //     Console.WriteLine(i);
        // }


    }
}
