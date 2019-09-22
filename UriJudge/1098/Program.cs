using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace URI1098Sequencia4
{
    class Program
    {
        static void Main(string[] args)
        {
            double I, J, value;
            int temp, temp2;

            for (I = 0, J= 1, value = 0, temp = 0, temp2 =0; I <= 2; J++ )
            {
                if (temp2 == 0)
                {
                    Console.WriteLine("I=" + I + " J=" + J);
                }
                else
                {
                    Console.WriteLine("I=" + I.ToString("F1", CultureInfo.InvariantCulture)+ " J="+ J.ToString("F1", CultureInfo.InvariantCulture));
                }
                temp++;

                if(temp == 3)
                {
                    I += 0.2;
                    value += 0.2;
                    J = value;
                    temp = 0;
                    temp2++;
                }
                if(temp2 == 5)
                {
                    temp2 = 0;
                }
            }

            Console.ReadLine();

        }
    }
}
