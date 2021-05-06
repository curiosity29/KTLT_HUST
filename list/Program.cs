using System;
using System.Collections.Generic;
namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }
        Program(){
            List<String> str = new List<String>();
            str.Add("doggo");
            str.Insert(0,"Chopin");
            str.Remove("doggo");
            string[] cpsList = {"Shostakovich", "Vivaldi", "Schubert"};
            str.AddRange(cpsList);
            Console.WriteLine("start with S: ");
            foreach(string s in str){
                if(s.StartsWith("S")) Console.WriteLine(s + " in index: " + str.IndexOf(s));
            }
        }
    }
}
