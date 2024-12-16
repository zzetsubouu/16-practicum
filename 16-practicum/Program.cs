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
            ArrayList list = new ArrayList();//0
            //1
            list.Add(3);
            list.Add("school");
            list.Add(true);
            list.Add(-2);
            list.Add(-4.8);
            //2
            Output(list);
            //3
            Console.WriteLine($"число элементов: {list.Count}");
            //4
            list.Add("word");
            //5
            Output(list);
            //6
            list.Remove(0);
            //7
            Output(list);
            //8
            list.Reverse();
            Output(list);
            //9
            list.AddRange( new string[] {"one","два","три"});
            //10
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
