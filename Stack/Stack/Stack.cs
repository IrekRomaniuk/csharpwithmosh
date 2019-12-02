using System;
using System.Collections.Generic;

namespace Stack
{
    public class Stack
    {
        private List<object> _stack = new List<object>();
        public void Push(object obj)
        {
            if (_stack == null)
            {
                throw new InvalidOperationException("Invalid ...");
            }
            _stack.Add(obj);
            //_stack.Reverse();
            /*foreach (var item in _stack)
            {
                Console.WriteLine("Item: {0}",item);
            }*/

        }
        public object Pop()
        {
            var result = _stack[_stack.Count - 1];
            //Console.WriteLine("Result: {0}", result);
            _stack.RemoveAt(_stack.Count - 1);
            return result;
        }
        public void Clear()
        {
            _stack.RemoveRange(0, _stack.Count - 1);
        }

    }
}
