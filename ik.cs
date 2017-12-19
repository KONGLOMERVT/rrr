using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_3
{
    class ik
    {
        Random r;
        public delegate void MaxKub();
        public event MaxKub vypalo;

        public ik()
        {
            r = new Random();
        }

        public int random()
        {
            int res = r.Next(6) + 1;
            if (res == 6)
            {
                vypalo?.Invoke();
            }
            return res;
        }
        
    }
}
