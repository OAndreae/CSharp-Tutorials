using System;
using System.Collections;
using System.Collections.Generic;

namespace StackExercise
{
    public class Stack
    {
        private readonly List<object> _list;

        public Stack()
        {
            _list = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("obj is null");

            _list.Add(obj);
        }

        public object Pop()
        {
            var size = _list.Count;
            if (size <= 0)
                throw new InvalidOperationException("stack is empty");

            var index = size - 1;

            var lastItem = _list[index];
            _list.RemoveAt(index);

            return lastItem;
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}
