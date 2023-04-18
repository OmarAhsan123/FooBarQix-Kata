using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKataProblem2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FooBarQix fooBarQix = new FooBarQix(15);

            Console.WriteLine(fooBarQix.GetFooBarQixResult());
            Console.ReadLine();
        }
    }
}
