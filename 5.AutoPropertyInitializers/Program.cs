using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.AutoPropertyInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Bird
    {
        public int Height { get; set; } = 20;
        public int Weight { get; set; } = 20;
        public string Name { get; set; } = "GG";
    }
}
