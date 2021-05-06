using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Program();
        }
        void p(string s){
            Console.WriteLine(s);
        }
        Program(){
            p(""+ kbit(7,3));
        }
        
        double newton(double x,string f,double upper, double lower, double precision){
            double dx=df(x,f)/fx(x,f);
            if(Math.Abs(dx)<= precision) return x;
            x= x-dx;
            if(x>lower && x< upper) return newton(x,f,upper,lower,precision);
            else throw new System.ArgumentException("out of root bound, check your input!!!");
        }
        private double fx(double x, string f)
        {
            throw new NotImplementedException();
        }

        private double df(double x, string f)
        {
            throw new NotImplementedException();
        }

        int kbit(int num, int k){
            
            return num^(1 << k-1);
        }
        
    }
}