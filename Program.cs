using System;

namespace _220530_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool a = Isprime(5);
            Console.WriteLine(a);
        }

        
        static bool Isprime(int number)
        {
            bool isPrime = true;

            for (int i = 2; i < number; i++)
            {
                if(number %1 == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
