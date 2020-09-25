using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework10
{
    public class MyList<T> : IEnumerable
    {
        private Node Head { get; set; }

        public IEnumerator GetEnumerator()
        {
            return new MyListEnumerator<T>(this);
        }
        public void Add(T value)
        {
            if(Head == null)
            {
                Head = new Node(value);
            }
            else
            {
                GetLastNode().Next = new Node(value);
            }
        }

        private Node GetLastNode()
        {
            if(Head != null)
            {
                return this[Count() - 1];
            }

            throw new NullReferenceException();
        }

        public int Count()
        {
            int result = 0;
            if(Head != null)
            {
                result = 1;
                Node current = Head;
                while(current.Next != null)
                {
                    result++;
                    current = current.Next;
                }
            }      

            return result;
        }

        public void Except(IEnumerable collection)
        {
            foreach(var element in collection)
            {
                for(int i = 0; i < Count(); i++)
                {
                    if (element.Equals(this[i].Value))
                    {
                        if(i == 0)
                        {
                            Head = this[1];
                            continue;
                        }
                        else if(i == (Count() - 1))
                        {
                            this[Count() - 2].Next = null;
                            continue;
                        }
                        this[i - 1].Next = this[i + 1];
                    }
                }
            }
        }
        
        public Node this[int i]
        {
            get
            {
                if (i >= Count())
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    int currentIndex = 0;
                    Node Current = Head;
                    while (currentIndex != i)
                    {
                        currentIndex++;
                        Current = Current.Next;
                    }

                    return Current;
                }
            }
        }

        public class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }

            public Node(T value)
            {
                Value = value;
            }
        }

    }
}
