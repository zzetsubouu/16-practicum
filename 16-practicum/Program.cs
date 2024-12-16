using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_practicum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(3);
            list.Add("school");
            list.Add(true);
            list.Add(-2);
            list.Add(-4.8);
            Output(list);
            Console.WriteLine($"число элементов: {list.Count}");
            list.Add("word");
            Output(list);
            list.Remove(0);
            Output(list);
            list.Reverse();
            Output(list);
            list.AddRange( new string[] {"one","два","три"});
            Output(list);
        }
        static void Output(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
