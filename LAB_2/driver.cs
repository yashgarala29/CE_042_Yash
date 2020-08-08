using System;
using my_prog;
namespace driver_prog
{
	public class my_driver_class
	{
		static void Main(string[] args)
		{
			 my_prog_class_m m = new my_prog_class_m();
			int mul = m.multiplication(5, 8);
			Console.WriteLine(mul);
			my_prog_class_a a = new my_prog_class_a();
			int add = a.addition(2, 3);
			Console.WriteLine(add);
			Console.ReadKey();
		}
	}
}