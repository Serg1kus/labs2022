using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int z;
            int N = 35;

            Console.WriteLine(0);

            for (int i = 0; i < N; i++)
            {
                if (x == 0)
                {
                    x = 1;
                }
                else
                {
                    z = x;
                    x = x + y;
                    y = z;
                }
                Console.WriteLine(x);
            }
        }
    }
}
