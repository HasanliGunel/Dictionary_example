using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary_field
{
    class Example
    {
        Dictionary<int, int> lookup = new Dictionary<int, int>
        {
            {1, 1},
            {2, 3},
            {3, 5},
            {6, 10},
        };
        public int GetValue()
        {
            return lookup[2];
        }
    }
}
