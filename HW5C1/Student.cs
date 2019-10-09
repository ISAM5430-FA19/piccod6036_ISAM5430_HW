using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5C1
{
    class Student
    {
        private string _studentnumber;
        private string _firstname;
        private string _lastname;
        private double _gpa;
        private string _classification;
        private string _major;
        
        public string Studentnumber { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public double GPA { get; set; }
        public string Classification { get; set; }
        public string Major { get; set; }

        public Student(string studentnumber, string firstname, string lastname)
        {
            Studentnumber = studentnumber;
            Firstname = firstname;
            Lastname = lastname;
        }

        public Student(string studentnumber, string firstname, string lastname, double gpa)
        {
            Studentnumber = studentnumber;
            Firstname = firstname;
            Lastname = lastname;
            GPA = gpa;
        }







    }
}
