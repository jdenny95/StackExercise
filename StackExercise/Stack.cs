using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace StackExercise
{
    public class Stack
    {
        private readonly List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("The object sent to stack can't be null");

            _list.Add(obj);
        }

        public object Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("The list must have objects first");

            var lastIndex = _list.Count - 1;

            var returnObjects = _list[lastIndex];

            _list.RemoveAt(lastIndex);

            return returnObjects;
        }

        public void Clear()
        {
            _list.Clear();
        }

        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}
