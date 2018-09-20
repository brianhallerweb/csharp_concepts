using System;
using System.Collections.Generic;

namespace Stack
{
    class Stack
    {
        private readonly List<object> _stack = new List<object>();

        public void Push(object record){
            if(record == null)
                throw new InvalidOperationException("can't add null to the stack");

            _stack.Add(record);
        }

         public object Pop(){
             if(_stack.Count == 0)
                throw new InvalidOperationException("stack is empty");

            var index = _stack.Count - 1;
            var element = _stack[index];
            _stack.RemoveAt(index);
            return element;
        }

          public void Clear(){
            _stack.Clear();
        }   
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

        }
    }
}
