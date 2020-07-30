using System;

namespace HelloWorld_LAB1
{
    class myfavorite
    {
        static void Main()
        {
            long no = Convert.ToInt64(Console.ReadLine());
            long sum=0;
            for (int i = 0; i <=no ; i++)
            {
                sum += i;
            }
            Console.WriteLine("sum of 0 to " + no + " is" + sum);
        }
    }
}
