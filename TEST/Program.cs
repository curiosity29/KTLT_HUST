using System;
using System.Linq;
using System.Collections.Generic;
namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new Program();
            for(;;);
        }
        Program()
        {
            do
            {
                Console.WriteLine("");
            } while (Console.ReadLine() != "0");
        }
        public static int find_it(int[] seq) 
      {
          var map = new Dictionary<int,int>();
          foreach(int n in seq)
          {
              if(map.ContainsKey(n)) map[n] ++;
              else map.Add(n,1);
          }
          foreach(int n in seq)
          {
              if(map[n] % 2 == 1) return n;
              Console.OutputEncoding = System.Text.Encoding.UTF8;
          }
          return -1;
      }
       
    }
}
