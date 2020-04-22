using System;

namespace Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            
            string question;
            Random Rnd = new Random(Guid.NewGuid().GetHashCode());
            int random = Rnd.Next(0, 8);

            Console.WriteLine("What is your name?");
            userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}!  What would you like to ask the magic eight ball?");
            question = Console.ReadLine();

            switch (random)
            {
                case 0:
                    Console.WriteLine("It is certain");
                    break;
                case 1:
                    Console.WriteLine("It is decidedly so");
                    break;
                case 2:
                    Console.WriteLine("Reply hazy try again");
                    break;
                case 3:
                    Console.WriteLine("Cannot predict now");
                    break;
                case 4:
                    Console.WriteLine("Do not count on it");
                    break;
                case 5:
                    Console.WriteLine("My sources say no");
                    break;
                case 6:
                    Console.WriteLine("Outlook not so good");
                    break;
                case 7:
                    Console.WriteLine("Signs point to yes");
                    break;

            }
            Console.ReadKey();
        }
    }
}
