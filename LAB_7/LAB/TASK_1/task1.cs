using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_AND_TASK
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr_of_1_to_100=new int[100];
            for (int i = 1; i <= 100; i++)
            {
                arr_of_1_to_100[i - 1] = i;
            }
            //List<int> ans = new List<int>;

            Console.WriteLine("----------list of all even number------");
            var ans=arr_of_1_to_100.Where(number=>number%2==0);
            foreach (var item in ans)
            {
                Console.Write(item+" ");
            }
            
            Console.WriteLine("\n----------list of all odd number------");
            ans = arr_of_1_to_100.Where(number => number % 2 != 0);
            foreach (var item in ans)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n----------list of all  number------");
            ans = arr_of_1_to_100.Where(number=>true);
            foreach (var item in ans)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n----------maximume and minimume------");
            int maximume = arr_of_1_to_100.Max();
            int minimume = arr_of_1_to_100.Min();
            Console.Write("Maximume number "+maximume+"\n");
            Console.Write("Minimume number " +minimume);
            Console.WriteLine("\n----------list of all  number------");
            double average = arr_of_1_to_100.Average();
            Console.Write(average + " ");
            Console.ReadLine();
            
        }
    }
}
