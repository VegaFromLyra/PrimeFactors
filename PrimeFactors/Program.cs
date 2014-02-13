using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 47;
            var result1 = GetPrimeFactors(n1);

            Console.WriteLine("Prime factors for {0} are", n1);
            foreach (var item in result1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            int n2 = 147;
            Console.WriteLine("Prime factors for {0} are", n2);
            var result2 = GetPrimeFactors(n2);

            foreach (var item in result2)
            {
                Console.Write(item + " ");
            }
        }

        // Time complexity

        // O(n * n) where n is the number of prime numbers less than n and not divisble by n
        static List<int> GetPrimeFactors(int n)
        {
            List<int> result = new List<int>();

            if (n == 0)
            {
                return result;
            }

            int prime = 2;

            bool done = false;

            int mod = 0;

            while (!done)
            {
                if (n == 1)
                {
                    done = true;
                }
                else
                {
                    mod = n % prime;

                    if (mod == 0)
                    {
                        result.Add(prime);
                        n = n / prime;
                    }
                    else
                    {
                        prime = GetNextPrime(prime); // 
                    }
                }
            }

            return result;
        }


        // O(n * squareroot(n))
        static int GetNextPrime(int prime)
        {
            int n = prime + 1;

            bool done = false;

            while (!done)
            {
                if (IsPrime(n))
                {
                    done = true;
                }
                else
                {
                    n++;
                }
            }

            return n;
        }

        // O(square root(n))
        static bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
