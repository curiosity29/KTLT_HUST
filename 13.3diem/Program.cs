using System;
using System.Numerics;
namespace _13._3diem
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }
        void p(string s){
            Console.WriteLine(s);
        }
        string i(){
            return Console.ReadLine();
        }
        Complex so_phuc(){
            p("nhap so phuc a+bi : ");
            p("nhap a: "); double a = Convert.ToDouble(i());
            p("nhap b: "); double b = Convert.ToDouble(i());
            return new Complex (a,b);
        }
        Program(){
            int size =3;
            Complex[] arr = new Complex[size];
            for(int i =0;i<size;i++){
                arr[i] = so_phuc();
            }
            if(check(arr)) p("cac diem thang hang");
            else p("cac diem khong thang hang");
        }
        bool check(Complex[] arr){
            bool flag = true;
            int size = arr.Length;
            int differ=0;
            for(int i =1;i< size;i++){
                if(arr[0]!= arr[i]) {
                    differ = i;
                    break;
                }
            }
            double slope=0;   //  y/x
            if(arr[0].Real == arr[differ].Real){
                slope = (arr[0].Imaginary - arr[differ].Imaginary)/( arr[0].Real - arr[differ].Real);
                for(int i =0; i<size;i++){
                    flag = (arr[0].Real == arr[differ].Real);
                }
            }
            else
            for(int i =0; i< size;i++){
                flag = (slope ==
                    (arr[0].Imaginary - arr[i].Imaginary)/( arr[0].Real - arr[i].Real)
                    );
            }

            return flag;
        }
    }
}
