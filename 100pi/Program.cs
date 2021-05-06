using System;
using System.IO;
using System.Linq;
namespace _100pi
{
    public class Program
    {
        public static void Main()
        {
            new Program(1000);
        }
        string normalize<T>(T s){
            return s.ToString().Replace(" ","");
        }
        void p<T>(T s)
        {
            Console.Write(s.ToString());
        }
        string piCal = "piCal";
        string piCheck = "piCheck2";
        Program()
        {
            p("nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            var arr = Enumerable.Repeat<Int32>(2, n).ToArray();
            var carry = Enumerable.Repeat<Int32>(0, n).ToArray();
            int sum;
            using var writer = new StreamWriter(piCal);
            int[] digit = new int[n / 4];
            for (int step = 1; step < n / 4; step++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[j] *= 10;
                }

                for (int i = n - 1; i > 1; i--)
                {
                    sum = arr[i] + carry[i];
                    carry[i - 1] = sum / (2 * i - 1) * (i - 1);
                    arr[i] = sum % (2 * i - 1);
                }
                sum = arr[1] + carry[1];
                arr[1] = sum % 10;
                digit[step] = sum / 10;

            }
            for (int i = n / 4 - 1; i > 0; i--)
            {
                if (digit[i] >= 10)
                {
                    digit[i] = digit[i] % 10;
                    digit[i - 1] += 1;
                }
            }
            writer.Write(digit[1]); writer.Write(".");
            for (int i = 2; i < n / 4; i++)
            {
                writer.Write(digit[i]);
            }
            p("done");
        }
        Program(int n){
            
            string cal = (new StreamReader(piCheck)).ReadToEnd();
            string check =(new StreamReader(piCal)).ReadToEnd();
            bool b = false;
            for (int i = 0;i<n;i++){
                b = cal[i] == check[i];
            }
            if(b)
            p("that was right to the "+ n + " digit");
        }
    }
}