using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Admin
    {
        public int Capacity { get; private set; }
        public void CheckCapacity(int capacity)
        {
            Capacity = capacity;
        }
    }
}
