//Class Excercise
using System;

namespace Targil_8A
{
    class Employee
    {
        string _firstname;
        string _familyname;
        string _idnumber;
        int _seniorty;
        string _edlvl;
        Employee(string firstname, string familyname, string idnumber, int seniority, string edlvl)
        {
            _firstname = firstname;
            _familyname = familyname;
            _idnumber = idnumber;
            _seniorty = seniority;
            _edlvl = edlvl;
        }
        void setName(string firstname, string familyname)
        {
            _firstname = firstname;
            _familyname = familyname;
        }
        string getName()
        {
            return _firstname;
            return _familyname;
        }
        void setID(string idnumber)
        {
            _idnumber = idnumber;
        }
        string getID()
        {
            return _idnumber;
        }
        void setSeniority(int sen)
        {
            _seniorty = sen;
        }
        int getseniority()
        {
            return _seniorty;
        }
        void seteducation(string edlvl)
        {
            _edlvl = edlvl;
        }
        string geteducation()
        {
            return _edlvl;
        }

        int calculate()
        {
            int salary = 0;
            if ((_seniorty >= 0) && (_seniorty <= 2))
            {
                salary = 1000;
            }
            if ((_seniorty >= 3) && (_seniorty <= 10))
            {
                salary = 2000;
                switch (_edlvl)
                {
                    case "A": salary += 200; break;
                    case "B": salary += 400; break;
                    case "C": salary += 600; break;
                    case "D": salary += 800; break;
                }
            }
            if ((_seniorty >= 11) && (_seniorty <= 20))
            {
                salary = 3000;
                switch (_edlvl)
                {
                    case "A": salary += 200; break;
                    case "B": salary += 400; break;
                    case "C": salary += 600; break;
                    case "D": salary += 800; break;
                }
            }
            if ((_seniorty >= 21) && (_seniorty <= 30))
            {
                salary = 5000;
            }
            if (_seniorty > 31)
            {
                Console.WriteLine("Seniority out of range, please input a number smaller than 31");
            }
            return calculate();
        }
        public static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                Console.WriteLine("Please input the employees private and family name");
                string name = Console.ReadLine();
                if (name == "end")
                {
                    Console.WriteLine("Thank you for using the program");
                    break;
                }
                Console.WriteLine("Please input employees ID number");
                int idnumber;
                if (!int.TryParse(Console.ReadLine(), out idnumber))
                {
                    Console.WriteLine("Please input a valid ID number, without letters");
                    continue;
                }
                Console.WriteLine("Please input eduation level, based on letters A - D");
                string edlvl = Console.ReadLine();
                if ((edlvl != "A") && (edlvl != "B") && (edlvl != "C") && (edlvl != "D"))
                {
                    Console.WriteLine("Please input a valid education level");
                    continue;
                }
                Console.WriteLine("Please input seniority in years, from 0 - 30");
                int seniority;
                if (!int.TryParse(Console.ReadLine(), out seniority) || (seniority < 0) || (seniority > 30))
                {
                    Console.WriteLine("Please input a valid number for seniority, from 0 - 30");
                    continue;
                }

            }
            Console.ReadKey();
        }
    }
}

//END PROGRAM