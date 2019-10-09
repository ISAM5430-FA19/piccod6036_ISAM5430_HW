using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW5C4
{
    class Program
    {
        static void Main(string[] args)
        {
            Park p1 = new Park("Hilltop", "Natchitoches", "Private", "lakeside", 400m, 8, 400, 160000m);
            WriteLine(p1.Type());
            WriteLine(p1.Facility());
            WriteLine(p1.Cost());
            WriteLine(p1.Revenue());
            WriteLine(p1.ToString());

        }
    }
}
