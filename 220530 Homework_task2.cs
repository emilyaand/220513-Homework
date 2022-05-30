using System;

namespace _220530_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 90, 60, 80 };
            double overage = Calavg(grades);

            if (overage > 60)
                Console.WriteLine("Congrutilations, u are passed");
            else
                Console.WriteLine("Sorry, u are failed");
        }

        
        static double Calavg(int[] arr)
        {
           int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum / arr.Length;
        }
    }
}
