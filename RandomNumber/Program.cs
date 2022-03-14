using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1-10
            //kui genereeritud number on 5, lõpetab tööd ja soovib "kena päeva"
            //kui gen. number on midagi muud, siis programm järkab oma tööd. 

            Random rnd = new Random();
            int i = 0;

            while(i !=5)
            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"juhuslik number on: { myRandomNumber }");
                if(myRandomNumber == 5)
                {
                    i = myRandomNumber;
                }
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
