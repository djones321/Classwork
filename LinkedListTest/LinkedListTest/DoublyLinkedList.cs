using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    public class DoublyLinkedList<T>
    {
        private DoubleNode<T> _head;
        private DoubleNode<T> _tail;
        private int _size;

        public DoublyLinkedList()
        {
            _head = null;
            _tail = null;
            _size = 0;
        }

        public void Add(T val)
        {
            DoubleNode<T> newNode = new DoubleNode<T>(val);

            if (_size == 0)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                _tail.Next = newNode;
                _tail.Next.Prev = _tail;
                _tail = newNode;
            }

            _size++;
        }

        public bool Remove(T val)
        {
            //is the list empty?
            if (_head == null)
            {
                return false;
            }
            //is the value in the head?
            else if (_head.Data.Equals(val))
            {
                _head = _head.Next;
                _size--;
                if (_head == null)
                {
                    _tail = null;
                }
                else
                {
                    _head.Prev = null;
                }
                return true;
            }
            //is the value in the tail?
            else if (_tail.Data.Equals(val))
            {
                _tail = _tail.Prev;
                _tail.Next = null;
                _size--;
                return true;
            }
            else
            {
                DoubleNode<T> temp = _head.Next;
                while (temp.Next != null)
                {
                    //is temp the one?
                    if (temp.Data.Equals(val))
                    {
                        DoubleNode<T> left = temp.Prev;
                        DoubleNode<T> right = temp.Next;
                        left.Next = right;
                        right.Prev = left;
                        _size--;
                        return true;
                    }
                    temp = temp.Next;
                }
            }

            return false;
        }
    }
}
