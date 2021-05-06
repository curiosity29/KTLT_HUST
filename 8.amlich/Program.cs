using System;

namespace _8.amlich
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
            const int pivot = 1984;   //giáp tý
            p("nhap nam: "); int nam = Convert.ToInt32(Console.ReadLine());
            int mod = nam - pivot;
            p("nam nay la: nam "+ mod10(mod%10)+ " " + mod12(mod%12));
        }

        string mod10(int mod){
            switch(mod){
                case 0: return "Giáp ";
                case 1: return "Ất";
                case 2: return "Bính";
                case 3: return "Đinh";
                case 4: return "Mậu";
                case 5: return "Kỷ";
                case 6: return "Canh";
                case 7: return "Tân";
                case 8: return "Nhâm";
                case 9: return "Quý";
                default: throw new ArgumentException("bad input");
            }
        }
        
        string mod12(int mod){
            switch(mod){
                case 0: return "Tý";
                case 1: return "Sửu";
                case 2: return "Dần";
                case 3: return "Mão";
                case 4: return "Thìn";
                case 5: return "Tỵ";
                case 6: return "Ngọ";
                case 7: return "Mùi";
                case 8: return "Thân";
                case 9: return "Dậu";
                case 10: return "Tuất";
                case 11: return "Hợi";
                default: throw new ArgumentException("bad input");
            }
        }
        }
}
