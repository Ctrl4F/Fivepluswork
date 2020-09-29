using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string Login;
            string Password;
            Console.WriteLine("Login");
            Login = Console.ReadLine();
            Console.WriteLine("Password");
            Password = Console.ReadLine();
             Random rnd = new Random();
            int sum = 0;
            
            for(int i = 0; i < 3; i++)
            {
               sum = rnd.Next(1, 7);
                Console.WriteLine($"random {sum}");
                sum = sum + sum;
            }
            if(Login == "lol" && Password == "W")
            {
                Console.WriteLine("Welcome, lol!!");
            }
            else
            {
                Console.WriteLine(sum);
            }
            
        }
    }
}
