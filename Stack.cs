using System;

using System.Collections.Generic;

namespace Stack_exercise 
{
    public class Stack
    {
        List<object> list = new List<object>();
 

        public Stack()
        {
            //list = new List<object>();
        }
        public void Push(object obj)
        {

            try
            {
                list.Add(obj);

                for (int i = list.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(list[i]);
                }

            }
            catch (System.InvalidOperationException)
            {
                System.Console.WriteLine("Please don't add null element to stack !");

            }
        }

        public void Pop()
        {
            try
            {

                list.RemoveAt(list.Count - 1);
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine(list[i]);
                }
            }
            catch (System.NullReferenceException)
            {
                System.Console.WriteLine("Please add at least 1 element to remove it from stack !");

            }

        }

        public void Clear()
        {
            if (list != null)
            {
                list.Clear();
            }
            else
            {
                System.Console.WriteLine("List is empty !");
            }

        }
    }
}
