using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Linq;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
        new Program();
        }
        const string fileName = @"D:\file\ReadMe.txt";
        Program(){// bài 1: 
        
            string[] sArr = File.ReadAllText(fileName).Trim().Split(" ");
            int sum =0;
          
            for(int i =1;i<sArr.Length;i++){
                if(sArr[i] %2 ==0) sum+=int.Parse(sArr[i]);
            }
            double average = (double)sum/ (sArr.Length/2);
           // Console.WriteLine(average);
            //extra part for bài 3:
            using var sw = new StreamWriter("ReadMe.txt");
            sw.WriteLine("average: " + average);
            int a=3;int b=8;
            netherSwap(ref a,ref b);
            Console.WriteLine("a: "+a);
            Console.WriteLine("b: " + b);
            double c =2/3;
            Console.WriteLine(c);
        }

        public void netherSwap<T>(ref T a,ref  T b){
            T c=b;
            b=a;
            a=c;
        }
    }
}
