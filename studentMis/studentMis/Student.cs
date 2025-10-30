using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentMis
{
    
    internal class Student
    {
        string firstName;
        string lastName;
        string id;
        int points;
        int[] grades = new int[3];
        public Student(string firstName, string lastName, string id, int points, int grade1, int grade2, int grade3)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.points = points;
            grades[0] = grade1;
            grades[1] = grade2;
            grades[2] = grade3;
        }

        public int GetPoints()
        {
            return points;
        }

        public void SetPoints(int pts)
        {
            points = pts;
        }
        public string GetFamilyName()
        {
            return lastName;
        }
        public string GetName()
        {
            return firstName;
        }
        public string GetId()
        {
            return id;
        }
        public double CalculatePayment()
        {
            double a = 22 - points;
            a /= 22;
            double pay = a * 10000;
            return pay;
        }
        public double CalculateGrades()
        {
            int sum = grades[0] + grades[1] + grades[2];
            double avg = sum / grades.Length;
            return avg;
        }

    }



}
