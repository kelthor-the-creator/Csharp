using System;
using System.Collections.Generic;
using System.Text;

namespace SieveErantothenes
{
    public class sieve
    {
        public static void sieveOferatosthenes(int n) {
            bool[] isprime = new bool[n + 1];
            for (int i = 0; i < n; i++)
                isprime[i] = true;
            for (int p = 2; p * p <= n; p++) { 
            if(isprime [p] == true)
                {
                    for (int i = p * p; i <= n; i += p)
                        isprime[i] = false;

                }
            }
            for (int i =2; i<=n; i++)
            {
                if (isprime[i] == true)
                {
                    Console.WriteLine(i + " ");
                }
            }

            
        }
    }
}
