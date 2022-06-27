using System;
using System.Threading;

namespace W2D4_RaffleExercise
{



    namespace Game
    {
        public class Raffle{
        
            public bool victory;

            // display welcome message
            public void Welcome()
            {
                Console.WriteLine("\n\n%&%&%&%&&%&%&&%&%&%&&%&%&&%&%");
                Console.WriteLine("Tervetuloa arpajaisiin!\n");
                Console.WriteLine("\n\n%&%&%&%&&%&%&&%&%&%&&%&%&&%&%\n");
            }

            // show dots while raffling
            static void ShowDots()
            {
                int i = 0;
                while (i < 3)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                    i++;
                }

                Console.WriteLine("\n\n");
            }

            void GetResult(int ticket)
            {
                var rand = new Random();
                if (ticket.CheckWin(rand.Next(10)))
                {
                    this.victory = true;
                }
                else
                {
                    this.victory = false;
                }
            }

            // play the game
            public void Play()
            {
                Console.WriteLine("Press any key to play\n");
                Console.ReadKey(true);
                Console.WriteLine("Pick a number from 1 to 10:");
                int ticket = int.Parse(Console.ReadLine());
                Console.Write("Raffling ");
                ShowDots();
                GetResult(ticket);
            }
        }
        class Exercise
        {
            static void Main(string[] args)
            {

                Raffle lotto = new Raffle();

                lotto.Welcome();
                lotto.Play();

                if (lotto.victory)
                {
                    Console.WriteLine("Congratulations! You won! \n");
                }
                else
                {
                    Console.WriteLine("You lost :( \n");
                }
                Console.WriteLine("*********************************");
            }
        }

        public static class ExtensionMethods
        {
            public static bool CheckWin(this int a, int b)
            {
                if (a == b || a > b)
                {
                    Console.WriteLine("Here is the prize!");
                    Console.WriteLine("GGGGGGGGGGGGGGGGGG");
                    return true;
                }
                return false;
            }
        }
    }

}
