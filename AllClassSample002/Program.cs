using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClassSample002
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            BaseClass o1 = new Class1();
            o1.Execute();
            o1.Begin();

            Console.ReadLine();
        }
    }
}
