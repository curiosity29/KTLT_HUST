using System;
using System.Collections.Generic;
namespace rabbit
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
        Program()
        {   
            List<List<int>> matrix = new List<List<int>>();
            List<int> intList;
            string input; int d;
            p("matrix pleas: ");
            do{
                intList = new List<int>();
                matrix.Add(intList);
                    while(true){
                    input = Console.ReadLine();
                    if(Int32.TryParse(input,out d)) intList.Add(Int32.Parse(input));
                    else if(input == "next" || input == "end") break;
                    }
            } while (input != "end");

            p(""+ sum(matrix));
        }
        
        // int sum(List<List<int>> matrix){
        //     int sum=0;
        //     foreach(List<int> list in matrix){
        //         foreach(int d in list){
        //             sum+= d;
        //         }
        //     }
        //     return sum;
        // }
        void add<T>(List<List<T>> list, int i,int j, T element){
            list[i].Insert(j, element);
        }
    }
}