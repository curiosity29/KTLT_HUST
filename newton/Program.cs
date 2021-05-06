using System;
namespace newton
{
    class Program
    {
       
        double f(double x)
        { return x*x-4; }
        double df(double x)
        { return (2*x); }
        double ddf(double x)
        { return 2; }
        static void Main(string[] args)
        {
            new Program();
           
            
            
        }
        Program(){
            double x;
            //input root range [a,b] and epsilon, m = min of |df(x)|
            double a,b,epsi,m;
            a= inp("a");
            b= inp("b");
            epsi= inp("epsilon");
            m= inp("min of f'(x)");
            //choose a starting point
            if (f(a) * ddf(a) < 0) x = b;
            else x = a;
            //main loop
            do { x = x - f(x) / df(x);
            } while (Math.Abs(f(x)) / m > epsi);
            Console.WriteLine(""+x);
        }
        double inp(string s)
        {
                Console.WriteLine("Nhap "+ s + ": ");
                return Convert.ToDouble(Console.ReadLine());
        }
    }
}