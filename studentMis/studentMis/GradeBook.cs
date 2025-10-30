using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentMis
{
    internal class GradeBook
    {
        Student Student;
        public GradeBook()
        {

        }

        public GradeBook(Student student)
        {
            Student = student;
        }
        public Student GetStudent()
        {
            return Student;
        }
        public void SetStudent()
        {
            Console.WriteLine("Enter First name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter ID: ");
            string id = Console.ReadLine();
            Console.WriteLine("Enter Points: ");
            int points = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter grade1: ");
            int grade1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter grade2: ");
            int grade2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter grade3: ");
            int grade3 = Convert.ToInt32(Console.ReadLine());
            Student = new Student(firstName, lastName, id, points, grade1, grade2, grade3);    
            
        }
        public void PrintInfo()
        {
            Console.WriteLine("the first name is: " + Student.GetName() + " the paymeant is: " + Student.CalculatePayment() + " student grade avg: " + Student.CalculateGrades());
        }
    }
}
