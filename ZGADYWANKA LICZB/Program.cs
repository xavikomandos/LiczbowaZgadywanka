using System;

namespace ZgadywankaLiczb
{
    class Liczby
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 10;
            int number;
            int guess;
            while (playAgain)
            {
                guess = 0;
                number = random.Next(min, max + 1);

                while ( guess != number)
                {
                    Console.WriteLine("Wybierz Liczbę od " + min + "  do  " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Twoja Liczba:   " + guess);
                    if (guess < number)
                    {
                        Console.WriteLine(" Za niska liczba ");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("  Za duża liczba  ");
                    }
                }
                Console.WriteLine("Zgadłeś");
            }
        }
    }
}