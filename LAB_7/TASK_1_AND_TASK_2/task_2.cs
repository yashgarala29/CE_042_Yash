using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_AND_TASK_2
{
    class task_2
    {
        static void Main(string[] args)
        {
            List<string> name_list = new List<string>();
            name_list.Add("yash");
            name_list.Add("darsh");
            name_list.Add("kunj");
            name_list.Add("kaka");
            name_list.Add("jay");
            name_list.Add("bus");
            name_list.Add("kai");
            name_list.Add("zzzz");
            name_list.Add("aaaa");
            name_list.Add("kkk");
            Console.WriteLine("----------name starting frome k------");
            var ans = name_list.Where(name => name.StartsWith("k"));
            foreach (var item in ans)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n----------names whose string length is less than 4------");
            ans = name_list.Where(name => name.Length<4);
            foreach (var item in ans)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n----------names whose string length is equal to 3------");
            ans = name_list.Where(name => name.Length == 4);
            foreach (var item in ans)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n----------names in Ascending order------");
            name_list.Sort();
            foreach (var item in name_list)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();


        }
    }
}
