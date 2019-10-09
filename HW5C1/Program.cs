using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW5C1
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("123", "Denise", "Crosby", 3.9);
            WriteLine(student1.Studentnumber);
            WriteLine(student1.Firstname);
            WriteLine(student1.Lastname);
            WriteLine(student1.GPA);

        }
    }
}
