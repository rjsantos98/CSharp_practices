using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URI1073QUADRADO
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double x;
            N = int.Parse(Console.ReadLine());
            x = 0;
            

            while(N<5 || N>2000)
            {
                N = int.Parse(Console.ReadLine());
            }

            for (int i=2; i<=N; i=i +2)
            {
                x = Math.Pow(i,2);
                Console.WriteLine(i+ "^2 = " + x);
            }
            Console.ReadKey();
        }
    }
}
