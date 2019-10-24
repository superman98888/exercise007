using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class stack 
    {
        int[] Buffer;
        int Top;
        public stack(int size)
        {
            Buffer = new int[size];
            Top = -1;
        }

        public void Push(int value)
        {
           Buffer[Top + 1] = value;
           Top++;
        }

        public int Pop()
        {
            int value = Buffer[Top];
            Top--;
            return value;
        }

        public int Peek()
        {
            int value = Buffer[Top];
            return value;
        }

        public int Count()
        {
            return Top + 1;
        }

        public void Clear()
        {
            Top = -1;
        }
    }
}
