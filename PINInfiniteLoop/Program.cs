using System;

namespace PINInfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //sisesta PIN-kood
            //võrdlen sesestatud PIN-koodi arvuga 1234
            //kui pin on 1234 siis kuvab tere tulemast
            //kui vale pin siis kuvab "vale pin proobi uuest" 
            //katsete arv on piiramatu

            bool LoopActive = true; //boolean --> true/fals
            int i = 0;

            while(LoopActive)
            {
                Console.WriteLine(); //cw + double TAB (saab kiiremini)
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    LoopActive = false;
                }
                else
                {
                    i++; 
                    Console.WriteLine("vale PIN. Proovi uuesti!");
                    Console.WriteLine($"Oled vale PIN-koodi {i} korda sisestanud.");
                }
            }


            Console.WriteLine("Kena päeva");
        }
    }
}
