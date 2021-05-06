using System;

namespace _6.chuan_hoa_xau
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
            p("nhap xau: ");
            string s = Console.ReadLine();
            p(chuan_hoa(s));
        }

        private string chuan_hoa(string s)
        {
            string str = "";
            string[] sArr = s.Split(" ");
            for(int i = 0;i< sArr.Length; i++){
                sArr[i]= sArr[i].Trim();
            }
            for(int i = 0;i< sArr.Length;i++){
                if(sArr[i] == "") continue;
                str += sArr[i]+ " ";
            }
            return str;
        }
    }
}
