using System;

namespace SixLines
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i > 0; i--) 
            {
                Console.WriteLine($"There are {i} bugs in the code. Fix one. ");
            }
            {
                Console.WriteLine($"There are no bugs in the code. That is wierd.");
            }
        }
    }
}
