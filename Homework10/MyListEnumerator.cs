using System;
using System.Collections;

namespace Homework10
{
    public class MyListEnumerator : IEnumerator
    {
        private MyList _myList;
        private int position;

        public MyListEnumerator(MyList myList)
        {
            _myList = myList;
            position = -1;
        }

        public object Current
        {
            get
            {
                if (position == -1 || position >= _myList.Count())
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return _myList[position].Value;
                }
            }
        }

        public bool MoveNext()
        {
            if(position < _myList.Count() - 1)
            {
                position++;

                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
