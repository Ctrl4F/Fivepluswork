using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name");
            string nameone = Console.ReadLine();
            Console.WriteLine("Enter the second name");
            string nametwo = Console.ReadLine();
            int lenghtone = 0;
            int lenghttwo = 0;
            foreach(char  letter in nameone)
            {
                lenghtone = lenghtone + 1;

            }
            foreach(char letter in nametwo)
            {
                lenghttwo = lenghttwo + 1;
            }
            if (lenghtone > lenghttwo)
            {
                Console.WriteLine("name one is the longest");

            }
            else if (lenghtone < lenghttwo)
            {
                Console.WriteLine("name two is the longest");

            }else
            {
                Console.WriteLine("both names are of the same lenght");

            }

        }
    }
}
