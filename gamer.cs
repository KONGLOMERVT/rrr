using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_3
{
    class gamer
    {
        string Name;
        ik seans;

        public gamer(string name)
        {
            Name = name;
            seans = new ik();
        }

        public int seansgame()
        {
            return seans.random();

        }

        public override string ToString()
        {
            return Name;
        }
        
    }
}
