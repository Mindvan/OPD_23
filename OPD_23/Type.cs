using System;
using System.Collections.Generic;
using System.Text;

namespace OPD_23
{
    public abstract class Type
    {
        public bool increase { get; private set; }
        public Type(bool val)
        {
            increase = val;
        }
        public abstract bool IsCorrect(int[] a, int[] b);

    }
}
