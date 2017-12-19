using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            gamer g1 = new gamer("Dosia");
            sobytie s = new sobytie();
            ik k = new ik();
            k.vypalo += s.Massage;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Выпало количество очков {0} для игрока {1}", k.random(), g1.ToString());
            }                       
            Console.ReadKey();
        }
    }
}
