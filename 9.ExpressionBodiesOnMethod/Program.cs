using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.ExpressionBodiesOnMethod
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class SortList
    {
        public override string ToString() => "SortList";

        public bool CheckIsValid(int index) => index > 10;

        public string OrderByWorld => "ASC";
    }
}
