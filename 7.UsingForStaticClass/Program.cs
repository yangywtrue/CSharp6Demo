using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace _7.UsingForStaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Max(random.Next(), random.Next());
            Console.ReadKey();
        }

        
    }
}
