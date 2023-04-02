using System;
using System.Collections.Generic;
using System.Text;

namespace Podliva
{
    class ArrayIndex<T>
    {
        ArrayFunc<double>[] data;
        public ArrayIndex()
        {
            data = new ArrayFunc<double>[5];
        }
    public ArrayFunc<double> this[int index]
    {
        get
        {
            return data[index];
        }
        set
        {
            data[index] = value;
        }
    }
}
}
