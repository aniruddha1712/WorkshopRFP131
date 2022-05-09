using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop131
{
    class PrimeFactors
    {
        public static void PrimeFact()
        {
            Console.WriteLine("Enter any number");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i=2; number > 1; i++)
            {
                if (number % i==0)
                {
                    int temp = 0;
                    while (number % i==0)
                    {
                        number /= i;
                        temp++;
                    }
                    Console.WriteLine("{0} is the prime factor of {1} times: ",i,temp);
                }
            }
        }
    }
}
