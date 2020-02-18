using System;
using System.Collections;

namespace stack
{
    public class Stack
    {
        private ArrayList elements;

        public Stack()
        {
            elements = new ArrayList();
        }

        public bool ifEmpty()
        {
            if (elements.Count == 0)
                return true;
            else
                return false;
        }

        public void Push(object obj)
        {
            if (obj != null)
            {
                elements.Add(obj);
            }
            else
                throw new InvalidOperationException();
        }

        public object Pop()
        {
            if (!ifEmpty())
            {
                object buffer = elements[elements.Count-1];
                elements.RemoveAt(elements.Count-1);
                return buffer;
            }
            else
                return null;


        }

        public void Clear()
        {
            if(!ifEmpty())
                elements.Clear();
            else
                Console.WriteLine("Stack is empty.");
        }

    }
}