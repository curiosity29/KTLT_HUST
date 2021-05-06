using System;

namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }
        Program()
        {
            greating();
            solEq();
        }
        private double solEq()
        {
            Double a = 0, b = 0, c = 0;                                                                 //double
            bool ok = false;                                                                            //bool
            int tolerance = 3;                                                                            //int
            while (!ok)
            {
                try
                {   
                    Console.WriteLine("Solving for x in the equation ax+b=c");
                    Console.WriteLine("Please enter a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter b:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter c:");
                    c = Convert.ToDouble(Console.ReadLine());
                    ok = true;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Something is wrong, want try again? ('yes' or 'no') ");
                    for (int i = 0; i < tolerance; i++)
                    {
                        switch (Console.ReadLine())
                        {
                            case "yes":
                                solEq();
                                break;
                            case "no": return 0;
                            default:
                                Console.WriteLine("What do you mean?");
                                break;
                        }
                    }
                }
            }
            if (a != 0) {
                Console.WriteLine($"x = {(c - b) / a}");
                return (c-b)/a;
            }
            else if (c - b == 0) Console.WriteLine("Equation satisfies for all x");
            else Console.WriteLine("No solution whatsoever");
            return 0;
        }

        private void greating()
        {
            string greating = "Hello World";                                                            //string
            Console.WriteLine(greating);
        }
    }
}
