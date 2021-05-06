using System;

namespace doc_stn
{
    class Program
    {
        static int stack = 0;
        static void Main(string[] args)
        {
            new Program();
        }
        static void p<T>(T s)
        {
            Console.WriteLine(s.ToString());
        }
        Program()
        {
            p("nhap so tu nhien: ");
            long stn;
            string n;
            do
            {
                n = Console.ReadLine();
            } while (!Int64.TryParse(n, out stn));

            p("cach doc: " + read(n));
        }
        static string read_3(string n)
        {
            string s = "";
            while (true)
            {
                switch (n.Length)
                {
                    case 3:
                        s = read_basic(n[0]) + " tram"; p("(case 3)" + s);
                        n = "" + n[1] + n[2];
                        continue;
                    case 2:
                        p("(case 2)" + s);
                        switch (n[0])
                        {
                            case '0':
                                if (n[1] == '0') return s;
                                else return s + " linh " + read_basic(n[1]);
                            case '1': s += " muoi"; break;
                            default:
                                s += " " + read_basic(n[0]) + " muoi";
                                break;
                        }
                        n = n[1].ToString();
                        continue;
                    case 1:
                        p("(case 1)" + s);
                        switch (n[0])
                        {
                            case '0': return s;
                            case '1': return s + " mot";

                            case '5': return s + " lam";
                            default: return s + " " + read_basic(n[0]);
                        }
                    default: return "bad input (number length)";
                }
            }
        }
        static string multi(int rank)
        {
            stack++;
            p("stack multi: " + stack);
            p(rank);
            if (rank > 9)
                return multi(rank - 9) + " ty";
            else if (rank == 9) return "ty";
            else
                switch (rank % 9)
                {
                    case 0: return "";
                    case 3: return "nghin";
                    case 6: return "trieu";
                    default: throw new ArgumentException("error: rank = " + rank);
                }
        }
        static string read_basic(char v)
        {
            stack++;
            p("stack readbasic: " + stack);

            switch (v)
            {
                case '0': return "khong";
                case '1': return "mot";
                case '2': return "hai";
                case '3': return "ba";
                case '4': return "bon";
                case '5': return "nam";
                case '6': return "sau";
                case '7': return "bay";
                case '8': return "tam";
                case '9': return "chin";
                default:
                    throw new ArgumentException(" bad input char ");
            }
        }
        static string read(string n)
        {
            string result = "", first = "";
            int mod = n.Length % 3;
            //3 so dau
            for (int i = 0; i < mod; i++)
            {
                first += n[i];
            }
            // 3 so tiep theo repeat
            p("mod: " + mod);
            if (first != "") first = read_3(first) + " " + multi(n.Length - mod);

            for (int i = mod; i < n.Length - mod; i += 3)
            {
                p(result);
                result += read_3("" + n[i] + n[i + 1] + n[i + 2])
                + " " + multi(n.Length - i - 3) + " ";
            }
            return first + " " + result;
        }
    }
}
