using System;

namespace project_euler_multiples_of_3_5.cs
{
    /*If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
     * The sum of these multiples is 23.
     *Find the sum of all the multiples of 3 or 5 below 1000.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int remainderFor3;
            int remainderFor5;
            int total = 0;
            Console.WriteLine("Hello World!");
            for(i = 0; i< 1000; i++)
            {
                remainderFor3 = i % 3;
                remainderFor5 = i % 5;
                if (remainderFor3 == 0 || remainderFor5 == 0)
                {
                    total = total += i;
                    Console.WriteLine(total);
                }
                
            };

        }
    }
}
