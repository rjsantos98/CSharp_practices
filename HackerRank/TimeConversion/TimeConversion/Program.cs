using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {
        static string timeConversion(string s)
        {
            string date = DateTime.Parse(s).ToString("HH:mm:ss");
            return date;
        }

        static void Main(string[] args)
        {
            //TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = timeConversion(s);

            Console.WriteLine(result);

            Console.Read();
        }
    }
}
