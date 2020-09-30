using System;

namespace Homework10
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList myList1 = new MyList();
            myList1.Add(8);
            myList1.Add(2);
            MyList myList2 = new MyList();
            myList2.Add(1);
            myList2.Add(2);
            myList2.Add(3);
            myList2.Add(4);
            myList2.Add(5);
            myList2.Add(6);
            myList2.Add(7);
            myList2.Add(8);
            myList2.Add(9);

            foreach (var a in myList2)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}
