using System;

namespace SieveErantothenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 50;
            sieve prime = new sieve();
            sieve.sieveOferatosthenes(n);
           
        }
    }
}
