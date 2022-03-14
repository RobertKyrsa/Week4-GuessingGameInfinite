using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1-10
            //kasutaja peab selle numbri ära arvama
            //kui kasutaja arvas numbri ära, siis ta võitis
            //kui ei arve kolme katsega ära siis võidab arvuti
            //*programm genereerib juhuslikku numbrit ühe korra

            
            Random rnd = new Random();
            int i = 0;


            while (i < 3)
            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine("Arva ära number 1-10! ");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (myRandomNumber == userNumber)
                {
                    Console.WriteLine("Palju õnne, oled võitnud!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale PIN. {3 - i } katset on jäänud.");
                    Console.WriteLine("vale number. Proovi uuesti!");
                }
            }
            



            Console.WriteLine("Kena päeva!");


        }
    }
}
