using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    public class SinglyLinkedList<T> : IEnumerable<T>
    {
        private Node<T> _head;
        private Node<T> _tail;
        private int _size;

        public SinglyLinkedList()
        {
            _head = null;
            _tail = null;
            _size = 0;
        }

        public void Add(T val)
        {
            Node<T> newNode = new Node<T>(val);

            if (_size == 0)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                _tail.Next = newNode;
                _tail = newNode;
            }

            _size++;
        }

        public bool Remove(T val)
        {
            if (_size == 0) return false;

            //value not in list

            //is the value in the head?
            if (_head.Data.Equals(val))
            {
                _head = _head.Next;
                if (_head == null)
                {
                    _tail = null;
                }
                _size--;
                return true;
            }

            Node<T> temp = _head;
            while (temp.Next != null)
            {
                if (temp.Next.Data.Equals(val))
                {
                    temp.Next = temp.Next.Next;
                    if (temp.Next == null)
                    {
                        _tail = temp;
                    }
                    _size--;
                    return true;
                }
                temp = temp.Next;
            }

            return false;
        }

        public bool Contains(T value)
        {
            Node<T> temp = _head;
            while (temp != null)
            {
                if (temp.Data.Equals(value))
                {
                    return true;
                }
                temp = temp.Next;
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder build = new StringBuilder();

            Node<T> temp = _head;
            while (temp != null)
            {
                build.Append(temp.Data.ToString() + " ");
                temp = temp.Next;
            }

            return build.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ListEnumerator(_head);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class ListEnumerator : IEnumerator<T>
        {
            private Node<T> _cur;

            public ListEnumerator(Node<T> first)
            {
                _cur = new Node<T>(default(T));
                _cur.Next = first;
            }

            public T Current
            {
                get
                {
                    return _cur.Data;
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                //return whether or not there is more data
                if (_cur == null) return false;
                _cur = _cur.Next;
                if (_cur == null) return false;
                else return true;
            }

            public void Reset()
            {
               
            }
        }
    }
}
