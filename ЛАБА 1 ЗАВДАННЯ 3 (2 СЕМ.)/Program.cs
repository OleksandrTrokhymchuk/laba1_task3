using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛАБА_1_ЗАВДАННЯ_3__2_СЕМ._
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int> { 1, 54, -32, 529, 10, 8232, 64, -9, 0 };

            var newlist = from i in list
                          where i >= 10 && i < 100
                          orderby i descending
                          select i;

            foreach (var i in newlist)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
