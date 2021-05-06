using System;
using static System.Math;
using System.Numerics;
using static System.Numerics.Complex;
namespace Base
{
    public class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }
        void p(string s){
            Console.WriteLine(s);
        }
        double i(){
            return Convert.ToInt64(Console.ReadLine());
        }
        Complex so_phuc(){
            p("nhap so phuc x+yi : ");
            p("nhap x: "); double a = Convert.ToDouble(i());
            p("nhap y: "); double b = Convert.ToDouble(i());
            return new Complex (a,b);
        }
        Program(){
            Complex a=so_phuc();
            Complex b=so_phuc();
            Complex c=so_phuc();
            Complex delta = Complex.Multiply(b,b) - Multiply(4,Complex.Multiply(a,c));
            p("x1 = " + Multiply(
                        Add(Negate(b),
                        Sqrt(Negate(delta)))
                        ,0.5));
                        
            p("x2 = " + Multiply(
                        Add(Negate(b),
                        Negate(Sqrt(delta)))
                        ,0.5));
        }
    }
}
