using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    public class DoubleNode<T>
    {
        private T _data;
        private DoubleNode<T> _next;
        private DoubleNode<T> _prev;

        public DoubleNode(T d)
        {
            _data = d;
            _next = null;
            _prev = null;
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

        public DoubleNode<T> Next
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

        public DoubleNode<T> Prev
        {
            get
            {
                return _prev;
            }
            set
            {
                _prev = value;
            }
        }
    }
}
