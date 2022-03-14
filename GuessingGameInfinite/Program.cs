using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1-10
            //kasutaja peab selle numbri ära arvama
            //kui kasutaja arvas numbri ära, siis ta võitis
            //katsete arv piiramatu 
            //*programm genereerib juhuslikku numbrit ühe korra

            

            bool LoopActive = true; //boolean --> true/fals
            Random rnd = new Random();
            int i = 0;


            while (LoopActive)
            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine("Arva ära number 1-10!");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (myRandomNumber == userNumber)
                {
                    Console.WriteLine("Palju õnne, oled võitnud!");
                    LoopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("vale number. Proovi uuesti!");
                    Console.WriteLine($"Oled vale Numbri {i} korda sisestanud.");
                }
            }




            Console.WriteLine("Kena päeva!");

        }
    }
}
