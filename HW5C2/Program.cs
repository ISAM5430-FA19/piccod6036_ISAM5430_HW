using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW5C2
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorway m1 = new Motorway("Gulf Freeway", "freeway", "south", "blacktop", 8, false, "HOTC");
            WriteLine(m1.ToString());
        }
    }
}
