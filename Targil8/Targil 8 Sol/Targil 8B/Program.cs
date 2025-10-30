//Class Excercise
using System;

namespace Targil_8B
{
    class Student
    {
        string _pname;
        string _fname;
        string _stunum;
        int _acapoints;
        double _stupay;
        Student (string pname, string fname, string stunum, int acapoints)
        {
            _pname = pname;
            _fname = fname;
            _stunum = stunum;
            _acapoints = acapoints;
        }

        string getpname()
        {
            return _pname;
        }
        string getfname()
        {
            return _fname;
        }
        string getstunum()
        {
            return _stunum;
        }
        void setacapoints(int acapoints)
        {
            _acapoints = acapoints;
        }
        int getacapoints()
        {
            return _acapoints;
        }
        double getstupay()
        {
            double stupay = ((22-(double)_acapoints) /22)*10000; 
            return _stupay;
        }
        static void Main(string[] args)
        {
            string pname = "", fname = "", stunum = "";
            double sum = 0, avg = 0, min = 0, max = 0;
            int acapoints, mone = 0;
            Student s = new Student("", "", "", -1);
            while (pname != "end")
            {
                Console.WriteLine("Please input a students first name, or input 'end' to exit the program");
                pname = Console.ReadLine();
                if (pname == "end")
                {
                    Console.WriteLine("Thank you for using the program!");
                    break;
                }
                Console.WriteLine("Please input a students family name");
                fname = Console.ReadLine();
                Console.WriteLine("Please input a students ID number");
                stunum = Console.ReadLine();
                Console.WriteLine("Please input the academic points of a student, a number between 0 - 22");
                if (!int.TryParse(Console.ReadLine(), out acapoints) || acapoints < 0 || acapoints > 23)
                {
                    Console.WriteLine("Please input a valid number");
                }
                
                s = new Student(pname, fname, stunum, acapoints);
                sum = s.getstupay();
                if (mone == 0)
                {
                    max = sum;
                    min = sum;
                }
                else if (sum > max)
                {
                    max = sum;
                }
                if (sum < min)
                {
                    min = sum;
                }
                mone++;
                avg += sum;
                pname = "";
                fname = "";
                stunum = "";
                sum = 0;
            }
            if (mone == 0)
            {
                Console.WriteLine("No new students were inputed");
            }
            else
            {
                Console.WriteLine($"The minimum amount owed is {min}, the maxmimum amount owed is {max}, the average amount owed is {avg / mone} NIS");
            }
        }
    }
}
// END PROGRAM
