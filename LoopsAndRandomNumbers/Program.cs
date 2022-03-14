using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //sisesta PIN-kood
            //võrdlen sesestatud PIN-koodi arvuga 1234
            //kui pin on 1234 siis kuvab tere tulemast
            //kui vale pin siis kuvab "vale pin proobi uuest" ja annab kolm katset

            int i = 0; //i - iteration

            while (i < 3) //While-loop
            {
                Console.WriteLine("Sisesta PIN-kood");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if (userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    //i = i + 1; on sama mis i++
                    i++;
                    Console.WriteLine($"Vale PIN. {3 - i } katset on jäänud.");
                }

               
                
            }


            Console.WriteLine("Kena päeva");
        }
    }
}
