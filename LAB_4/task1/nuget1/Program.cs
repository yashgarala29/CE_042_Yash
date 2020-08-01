using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using operetion_namespace;
namespace nuget1
{
    class Program
    {
        static void Main(string[] args)
        {
            operetion_class op = new operetion_class();
            Console.WriteLine("addition ="+op.add(5, 8));
            Console.WriteLine("maximum 5 and 8 ="+op.max(5, 8));
            Console.WriteLine("multipication 5 and 8 =" + op.mul(5, 8));
            Console.WriteLine("sub 5 and 8 =" + op.sub(5, 8));


        }
    }
}
