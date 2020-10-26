using System;


namespace Lab_0
{
    public class primenums
    {



        public static void Main(string[] args)
        {
            Console.WriteLine("prime numbers: ");
            bool isprime = true;

            for (int i= 2; i<= 15; i++)
            {
                for(int j = 2; j<= 15; j++)
                {
                    if( i != j && i%j== 0)
                    {
                        isprime = false;
                            break;
                    }
                }
                if (isprime)
                {
                    Console.Write("\t " + i);
                }
                isprime = true;
            }
            Console.ReadKey();
        }
    }
}

