using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace WorkshopGPA
{
    public class GPACalculator
    {
        private double na, nbplus, nb, ncplus, nc, ndplus, nd, nf;
        private double totalGPA;
        private List<Student> StuDent = new List<Student>();

        public void setStudent(Student student)
        {
            this.StuDent.Add(student);
        }
        //คำนวณคะแนนเฉลี่ย
        public double getAVGscore() 
        {
           double sum = 0 ;
            foreach (Student student in StuDent) 
            {
                sum += student.getscore();
            }
            return sum / this.StuDent.Count;
        }
        // คำนวณคะแนนสูงสุด
        public double getHighestScore()
        {
            double highestScore = 0;
            
            foreach (Student student in StuDent)
            {
                if (student.score > highestScore)
                {
                    highestScore = student.score;
                }
            }
            return highestScore;
        }
        // คำนวณหาคะแนนต่ำสุด
        public double getLowestScore()
        {
            double lowestScore = getHighestScore();

            foreach (Student student in StuDent)
            {
                if (student.score < lowestScore)
                {
                    lowestScore = student.score;
                }
            }
            return lowestScore;
        }
       //หาชื่อคนที่ได้คะแนนสูงสุด
        public string getHighestName()
        {
            string highestName = string.Empty;
            double highestScore = 0;
            foreach (Student student in StuDent)
            {
                if (student.score > highestScore)
                {
                    highestScore = student.score;
                    highestName = student.studentName;
                }
            }
            return highestName;
        }
        //หาชื่อคนที่ได้คะแนนต่ำสุด
        public string getLowestName()
        {
            string lowestName = getHighestName();
            double lowestScore = getHighestScore();
            foreach (Student student in StuDent)
            {
                if (student.score < lowestScore)
                {
                    lowestScore = student.score;
                    lowestName = student.studentName;
                }
            }

            return lowestName;
        }

        //คำนวณGPA
        public double getGPA(double score)
        {
                if (score >= 80 && score <= 100)
                {
                    score = 4.0;
                    na++;
                }
                else if (score >= 75 && score < 79)
                {
                    score = 3.5;
                    nbplus++;
                }
                else if (score >= 70 && score < 74)
                {
                    score = 3.0;
                    nb++;
                }
                else if (score >= 65 && score < 69)
                {
                    score = 2.5;
                    ncplus++;
                }
                else if (score >= 60 && score < 64)
                {
                    score = 2.0;
                    nc++;
                }
                else if (score >= 55 && score < 59)
                {
                    score = 1.5;
                    ndplus++;
                }
                else if (score >= 50 && score < 54)
                {
                    score = 1.0;
                    nd++;
                }
                else
                {
                    score = 0;
                    nf++;
                }
            

            totalGPA = (na * 4.0) + (nbplus * 3.5) + (nb * 3.0) + (ncplus * 2.5) + (nc * 2.0) + (ndplus * 1.5) + (nd * 1.0);

            double GPA2 = totalGPA / this.StuDent.Count;
            return GPA2;
        }

    }
}
    