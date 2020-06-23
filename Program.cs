using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int startRange;
            int endRange;
            int midRange = 50;
            int result = 0;

            Console.Write("Chose the minimum number > ");
            startRange = Int32.Parse(Console.ReadLine());

            if (startRange != 0)
            {
                Console.WriteLine("I hate you... You didn't read the instructions!");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }

            Console.Write("Chose the maximum number > ");
            endRange = Int32.Parse(Console.ReadLine());

            if (endRange != 100)
            {
                Console.WriteLine("I hate you... You didn't read the instructions!");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }

            Console.Write("Chose the mid range number > ");
            midRange = Int32.Parse(Console.ReadLine());

            if (midRange <= startRange)
            {
                Console.WriteLine("I hate you... You didn't read the instructions!");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }

            if (midRange >= endRange)
            {
                Console.WriteLine("I hate you... You didn't read the instructions!");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }

            Random r = new Random();
            int rInt = r.Next(startRange, endRange);

            if (rInt > midRange)
            {
                result = 2;
            }

            if (rInt < midRange)
            {
                result = 1;
            }

            Console.WriteLine(rInt.ToString());
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }
}
