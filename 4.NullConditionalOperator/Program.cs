using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.NullConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            users.Add(new User());

            if (users.FirstOrDefault()?.nickNames == null)
            {
                Console.WriteLine("NickNames is Empty");
            }

            Console.ReadKey();
        }
    }

    public class User {

        public List<string> nickNames;
    }
}
