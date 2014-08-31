using System;

namespace PositiveSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;

            for (int i = 0; i < 3; i++)
            {
                num = Int32.Parse(Console.ReadLine());
                if (num >= 0)
                {
                    sum = sum + num;
                }
            }
            Console.WriteLine("The Positive Sum is" + sum);
        }
    }
}