using System;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(new DateTime(0));
            stack.Push(DateTime.Now);
            stack.Push("Marek Walczyk");
            stack.Push("Warek Malczyk");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.Clear();
            stack.Push("Marek Walczyk");

            if (stack.ifEmpty())
                Console.WriteLine("Stack is empty");
            else
                Console.WriteLine("Stack is not empty");
            try
            {
                stack.Push(null);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Null is not stack's friend :(");
            }
        }
    }
}
