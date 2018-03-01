using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //create list of ints with 1-10
            /* SinglyLinkedList<int> list = new SinglyLinkedList<int>();
             for (int i = 1; i <= 10; i++)
             {
                 list.Add(i);
             }

             foreach (int num in list)
             {
                 Console.WriteLine(num);
             }*/

            //reverse a string
            string test = "banana";
            Stack<char> st = new Stack<char>();
            foreach (char letter in test)
            {
                st.Push(letter);
            }
            StringBuilder result = new StringBuilder();
            while (st.Count != 0)
            {
                result.Append(st.Pop());
            }

            Console.WriteLine(result.ToString());


            //pause
            Console.ReadLine();
        }
    }
}
