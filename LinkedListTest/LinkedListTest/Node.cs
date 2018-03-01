using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    public class Node<T>
    {
        private T _data;
        private Node<T> _next;

        public Node(T d)
        {
            _data = d;
            _next = null;
        }

        public T Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }

        public Node<T> Next
        {
            get
            {
                return _next;
            }
            set
            {
                _next = value;
            }
        }
    }
}
