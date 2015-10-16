using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Algorithms
{
    class StacksImplementedWithArray
    {
        int _stackOneIdx = -3;
        int _stackTwoIdx = -2;
        int _stackThreeIdx = -1;
        object[] _stack = new object[99];

        public void Push(object item, StackNumber stackNumber)
        {
            if (stackNumber == StackNumber.One)
            {
                _stackOneIdx += 3;
                this.PushHelper(_stackOneIdx, item);
            }
            else if (stackNumber == StackNumber.Two)
            {
                _stackTwoIdx += 3;
                this.PushHelper(_stackTwoIdx, item);
            }
            else if (stackNumber == StackNumber.Three)
            {
                _stackThreeIdx += 3;
                this.PushHelper(_stackThreeIdx, item);
            }
        }

        private void PushHelper(int idx, object item)
        {
            if (idx >= _stack.Length)
            {
                object[] newStack = new object[_stack.Length * 2];
                for (int i = 0; i < _stack.Length; i++)
                    newStack[i] = _stack[i];
                _stack = newStack;
            }
            _stack[idx] = item;
        }

        public object Pop(StackNumber stackNumber)
        {
            object item = null;

            if (stackNumber == StackNumber.One)
            {
                item = this.PopHelper(_stackOneIdx);
                if (item != null)
                    _stackOneIdx -= 3;
            }
            else if (stackNumber == StackNumber.Two)
            {
                item = this.PopHelper(_stackTwoIdx);
                if (item != null)
                    _stackTwoIdx -= 3;
            }
            else if (stackNumber == StackNumber.Three)
            {
                item = this.PopHelper(_stackThreeIdx);
                if (item != null)
                    _stackThreeIdx -= 3;
            }

            return item;
        }

        private object PopHelper(int idx)
        {
            if (idx < 0)
                return null;
            else
                return _stack[idx];
        }

        public object Peek(StackNumber stackNumber)
        {
            object item = null;

            if (stackNumber == StackNumber.One)
            {
                item = _stack[_stackOneIdx];
            }
            else if (stackNumber == StackNumber.Two)
            {
                item = _stack[_stackOneIdx];
            }
            else if (stackNumber == StackNumber.Three)
            {
                item = _stack[_stackOneIdx];
            }

            return item;
        }
    }

    public enum StackNumber
    {
        One,
        Two,
        Three
    }
}
