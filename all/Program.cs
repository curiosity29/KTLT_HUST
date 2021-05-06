using System;
using System.Numerics;
using System.Collections.Generic;
namespace all
{
    class Amlich                //8
    {
        static void Main(string[] args)
        {
            new Program();
        }
        void p(string s)
        {
            Console.WriteLine(s);
        }
        Program()
        {
            const int pivot = 1984;   //giáp tý
            p("nhap nam: "); int nam = Convert.ToInt32(Console.ReadLine());
            int mod = nam - pivot;
            p("nam nay la: nam " + mod10(mod % 10) + " " + mod12(mod % 12));
        }

        string mod10(int mod)
        {
            switch (mod)
            {
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
        string mod12(int mod)
        {
            switch (mod)
            {
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

    class Stn                   //9
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

    class DFS                   //10
    {
        private int V; // No. of vertices  


        private List<int>[] adj;

        Graph(int v)
        {
            V = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; ++i)
                adj[i] = new List<int>();
        }

        //Function to Add an edge into the graph  
        void AddEdge(int v, int w)
        {
            adj[v].Add(w); // Add w to v's list.  
        }

        // A function used by DFS  
        void DFSUtil(int v, bool[] visited)
        {

            visited[v] = true;
            Console.Write(v + " ");


            List<int> vList = adj[v];
            foreach (var n in vList)
            {
                if (!visited[n])
                    DFSUtil(n, visited);
            }
        }

        void DFS(int v)
        {

            bool[] visited = new bool[V];

            //print DFS traversal  
            DFSUtil(v, visited);
        }

        public static void Main(String[] args)
        {
            Graph g = new Graph(4);

            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);
            Console.WriteLine("Following is Depth First Traversal " +
                              "(starting from vertex 2)");
            g.DFS(2);
            Console.ReadKey();
        }
    }

    class Pi100                 //12
    {
        public static void Main()
        {
            new Program(1000);
        }
        string normalize<T>(T s)
        {
            return s.ToString().Replace(" ", "");
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
        Program(int n)
        {

            string cal = (new StreamReader(piCheck)).ReadToEnd();
            string check = (new StreamReader(piCal)).ReadToEnd();
            bool b = false;
            for (int i = 0; i < n; i++)
            {
                b = cal[i] == check[i];
            }
            if (b)
                p("that was right to the " + n + " digit");
        }
    }

    class LineChecker           //13  
    {
        static void Main(string[] args)
        {
            new Program();
        }
        void p(string s)
        {
            Console.WriteLine(s);
        }
        string i()
        {
            return Console.ReadLine();
        }
        Complex so_phuc()
        {
            p("nhap so phuc a+bi : ");
            p("nhap a: "); double a = Convert.ToDouble(i());
            p("nhap b: "); double b = Convert.ToDouble(i());
            return new Complex(a, b);
        }
        Program()
        {
            int size = 3;
            Complex[] arr = new Complex[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = so_phuc();
            }
            if (check(arr)) p("cac diem thang hang");
            else p("cac diem khong thang hang");
        }
        bool check(Complex[] arr)
        {
            bool flag = true;
            int size = arr.Length;
            int differ = 0;
            for (int i = 1; i < size; i++)
            {
                if (arr[0] != arr[i])
                {
                    differ = i;
                    break;
                }
            }
            double slope = 0;   //  y/x
            if (arr[0].Real == arr[differ].Real)
            {
                slope = (arr[0].Imaginary - arr[differ].Imaginary) / (arr[0].Real - arr[differ].Real);
                for (int i = 0; i < size; i++)
                {
                    flag = (arr[0].Real == arr[differ].Real);
                }
            }
            else
                for (int i = 0; i < size; i++)
                {
                    flag = (slope ==
                        (arr[0].Imaginary - arr[i].Imaginary) / (arr[0].Real - arr[i].Real)
                        );
                }

            return flag;
        }
    }

    class Miller                //final
    {
        string path = "primality";
        static void Main(string[] args)
        {
            new Program();
        }
        BigInteger power(BigInteger a, BigInteger k, BigInteger n)
        {
            BigInteger result = 1;
            while (k > 0)
            {
                if (k % 2 == 1) result *= a;
                a = (a * a) % n;
                k /= 2;
                // p("a: "); p(a);
                // p(result);
            }
            return result;
        }
        void p<T>(T s)
        {
            Console.WriteLine(s.ToString());
        }
        int shift(BigInteger n)
        {
            n = n - 1;
            int count = 0;
            while (n % 2 == 0)
            {
                n = n >> 1;
                count++;
            }
            return count;
        }
        Program()
        {
            //p("nhap n: ");
            //p(power(3,3,5));
            BigInteger n = 12345678;    //n-1 = 2^e *k
            using var sw = new StreamWriter(path);
            BigInteger k, e;
            BigInteger ak;     //a^k
            bool prime = false;
            BigInteger line = 0;
            for (BigInteger i = 3; i < n; i += 2)
            {
                prime = false;

                e = shift(i);

                k = (i - 1);
                for (int h = 0; h < e; h++)
                {
                    k = k >> 1;
                }

                for (BigInteger a = 2; a < 4; a++)
                {
                    ak = power(a, k, i);
                    // p("ak" + ak);
                    if (ak % i == 1) prime = true;
                    else
                        for (BigInteger j = 0; j < e; j++)
                        {
                            // p("ak" + ak);
                            if (ak % i == i - 1)
                            {
                                prime = true;
                                break;
                            }
                            ak = (ak * ak) % i;
                        }
                    if (prime) break;
                }
                if (prime) sw.Write(String.Format("{0,6}: {1,-10}", i, "prime"));
                else sw.Write(String.Format("{0,6}: {1,-10}", i, ""));
                line++;
                if (line % 10 == 9)
                {
                    line++;
                    sw.WriteLine("");
                }
            }
            p("done");
        }
    }

}
static void main(string[] args)
{
    new test();
}
test()
{
    string input;
    int func;
    do
    {
        p("choose 1 function to execute: ");
        do
        {

            input = Console.ReadLine();
        } while (!Int32.TryParse(input, out func));

    } while (Console.ReadLine() != "gg");
    void p<T>(T s)
    {
        Console.WriteLine(s.ToString());
    }
}
    