using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopGPA
{
    public class Student
    {
        public string studentName;
        public double score;
        public Student(string studentName, double score)
        {
            this.studentName = studentName;
            this.score = score;
        }
        public double getscore() 
        { 
            return score;
        }
    }
}
