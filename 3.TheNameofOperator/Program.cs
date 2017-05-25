using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.TheNameofOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            Console.WriteLine(nameof(account.language));

            Console.ReadKey(); 
        }


        public class Account
        {
            public string language;
        }
    }
}
