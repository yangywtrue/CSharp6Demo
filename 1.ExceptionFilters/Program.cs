using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ExceptionFilters
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //throw new Exception("1");
                throw new Exception("2");
            }
            catch (Exception ex) when (ex.Message == "1")
            {
                Console.WriteLine("1");
            }
            catch (Exception ex) when (ex.Message == "2")
            {
                Console.WriteLine("2");
            }

            Console.ReadKey();
        }
    }
}
