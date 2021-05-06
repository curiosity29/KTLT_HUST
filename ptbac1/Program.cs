using System;

namespace ptbac1
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
        Program(){
            p("nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool[] arr = new bool[n+1];
            for(int i = 2; i<=n; i++){
                if(arr[i]) continue;
                for(int j =2*i;j <= n;j += i){
                    arr[j] = true;
                }
            }
            for(int i = 2;i<=n;i++){
                if(!arr[i]) p(""+i);
            }
        }
    }
}
