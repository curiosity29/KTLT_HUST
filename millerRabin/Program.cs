using System;
using System.IO;
using System.Numerics;
namespace millerRabin
{
    class Program
    {
        string path = "primality";
        static void Main(string[] args)
        {
            new Program();
        }
        BigInteger power(BigInteger a, BigInteger k, BigInteger n)
        {
            BigInteger result = 1;
            while (k > 0)
            {
                if (k % 2 == 1) result *= a;
                a = (a * a) % n;
                k /= 2;
                // p("a: "); p(a);
                // p(result);
            }
            return result;
        }
        void p<T>(T s)
        {
            Console.WriteLine(s.ToString());
        }
        int shift(BigInteger n)
        {
            n = n - 1;
            int count = 0;
            while (n % 2 == 0)
            {
                n = n >> 1;
                count++;
            }
            return count;
        }
        Program()
        {
            //p("nhap n: ");
            //p(power(3,3,5));
            BigInteger n = 12345678;    //n-1 = 2^e *k
            using var sw = new StreamWriter(path);
            BigInteger k, e;
            BigInteger ak;     //a^k
            bool prime = false;
            BigInteger line = 0;
            for (BigInteger i = 3; i < n; i += 2)
            {
                prime = false;

                e = shift(i);
                
                k = (i-1);
                for(int h=0;h<e;h++){
                    k= k>>1;
                }
 
                for (BigInteger a = 2; a < 4; a++)
                {
                    ak = power(a, k, i);
                    // p("ak" + ak);
                    if (ak % i == 1) prime = true;
                    else
                        for (BigInteger j = 0; j < e; j++)
                        {
                            // p("ak" + ak);
                            if (ak % i == i - 1)
                            {
                                prime = true;
                                break;
                            }
                            ak = (ak * ak) % i;
                        }
                    if (prime) break;
                }
                if (prime) sw.Write(String.Format("{0,6}: {1,-10}", i, "prime"));
                else sw.Write(String.Format("{0,6}: {1,-10}", i, ""));
                line++;
                if (line % 10 == 9)
                {
                    line++;
                    sw.WriteLine("");
                }
            }
            p("done");
        }
    }
}
