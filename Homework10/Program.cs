using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList1 = new MyList<int>();
            myList1.Add(8);
            myList1.Add(45);
            MyList<int> myList2 = new MyList<int>();
            myList2.Add(1);
            myList2.Add(2);
            myList2.Add(3);
            myList2.Add(4);
            myList2.Add(5);
            myList2.Add(6);
            myList2.Add(7);
            myList2.Add(8);
            myList2.Add(9);

            //Console.WriteLine(myList1.Count());
            foreach (var a in myList2)
            {
                Console.WriteLine(a);
                Console.WriteLine("=====================");
            }
            myList2.Except(myList1);
            foreach(var a in myList2)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}
