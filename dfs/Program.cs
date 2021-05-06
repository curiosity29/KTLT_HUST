using System;
using System.Numerics;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Program();
        }
        void p<T>(T s)
        {
            Console.WriteLine(s);
        }
        /*  steps:
         *  break n into odd*2^e form
         *  with any base a in chosen range:
         *  calculate a^k mod n, with k from 1 to e
         *  if none is 1 then it's not prime
         */
        Program()
        {
            p("input n for prime testing: ");
            var n = BigInteger.Parse(Console.ReadLine());
            BigInteger odd, e, aPow;
            bool isPrime = true;
            decompose(n, out odd,out e);
            for (int a = 0; a < 20; a++)
            {
                aPow = modPow(a, odd, n);
                for(int i=0;i<e;i++)
                {
                    if(aPow == 1)
                    {
                        isPrime= false;
                        break;
                    }    
                    aPow = aPow * aPow %n;
                }
                if(!isPrime) break;
            }
            if(isPrime) p("prime, propably ...");
            else p("definately composite");
        }
        void decompose(BigInteger n, out BigInteger odd, out BigInteger e)
        {
            e = 0;
            while (n %2 == 0)
            {
                n=n >> 1;
                e++;
            }
            odd = n;
        }
        BigInteger modPow(int a, BigInteger exponent, BigInteger mod)
        {
            int result =1;
            while (exponent>0)
            {
                if (exponent %2 == 1) result = result*a% mod;
                    a =(int)(a*a% mod) ;
                    exponent = exponent >>1;   
            }
            return a;
        }
    }
}
