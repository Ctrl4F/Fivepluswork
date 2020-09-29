using System;
using System.Dynamic;
using System.Security;

namespace ForWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sum = 0;
            int myRandomNumber;
            for(int i = 0; i < 5; i++)
            {
                myRandomNumber = rnd.Next(1, 7);
                Console.WriteLine($"random {myRandomNumber}");
                sum = sum + myRandomNumber;
            }
            
            Console.WriteLine(sum);
            
        }
             
            
        
    }
}
