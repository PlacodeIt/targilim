using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Person
{
    class Person
    {
        string _name;
        int _age;
        double _height;

        Person(string n, int a, double h)
        {
            _name = n;
            _age = a;
            _height = h;
        }

        void PrintInfo()
        {
            Console.WriteLine(_name + " " + _age + " " + _height);
        }

        void SetAge(int a)
        {
            _age = a;
        }

        void SetName(string n)
        {
            _name = n;
        }

        void SetHeight(double h)
        {
            _height = h;
        }

        string GetName()
        {
            return _name;
        }

        int GetAge()
        {
            return _age;
        }

        double GetHeight()
        {
            return _height;
        }

        static void Main(string[] args)
        {
            //stage 1
            Console.WriteLine("Please enter your details: name, age, height - each in a separate line");
            string n = Console.ReadLine();
            int a;
            double h;
            if (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("wrong value");
            }
            else {
                if (!double.TryParse(Console.ReadLine(), out h))
                {
                    Console.WriteLine("wrong value");
                }
                else { 
                    Person p1 = new Person(n, a, h);
                    p1.PrintInfo();
                    p1.SetAge(18);
                    p1.SetName("Adi");
                    p1.SetHeight(1.75);
                    p1.PrintInfo();
                }
            }
            //stage 2
            int count = 0, sum = 0;
            double sumH = 0;
                //get persons until "end" and calculate their average age
            while (true)
                {
                    if (count == 3) break;
                    Console.WriteLine("Please enter your details: name, age, height - each in separate line");
                    n = Console.ReadLine();
                    if (n == "end") break;

                    if (int.TryParse(Console.ReadLine(), out a) && double.TryParse(Console.ReadLine(), out h))
                    {
                        Person p2 = new Person(n, a, h);
                        p2.PrintInfo();
                        count++;
                        sum += p2.GetAge();
                        sumH+= p2.GetHeight();
                }

                }
            if (count > 0)
            {
                Console.WriteLine("the average age is: " + ((double)sum) / count);
                Console.WriteLine("the average height is: " + sumH / count);
            }
            else Console.WriteLine("no persons were entered");
            
            Console.ReadKey();
            /* OPTIONAL - the solution without a loop - get two more persons and sort and print p1,p2,p3 in anscending order of their ages.
            Console.WriteLine("Please enter your details: name, age, height - each in separate line");

            n = Console.ReadLine();
            a = Convert.ToInt32(Console.ReadLine());
            h = Convert.ToDouble(Console.ReadLine());
            Person p2 = new Person(n, a, h);

            Console.WriteLine("Please enter your details: name, age, height - each in separate line");
            
            n = Console.ReadLine();
            a = Convert.ToInt32(Console.ReadLine());
            h = Convert.ToDouble(Console.ReadLine());
            Person p3 = new Person(n, a, h);

            if (p1.GetAge() > p2.GetAge())
                if (p2.GetAge() > p3.GetAge())
                {
                    p3.PrintInfo();
                    p2.PrintInfo();
                    p1.PrintInfo();
                }
                else
                    if (p3.GetAge() > p1.GetAge())
                    {
                        p2.PrintInfo();
                        p1.PrintInfo();
                        p3.PrintInfo();
                    }
                    else
                    {
                        p2.PrintInfo();
                        p3.PrintInfo();
                        p1.PrintInfo();
                    }
            else
                if (p1.GetAge() > p3.GetAge())
                {
                    p3.PrintInfo();
                    p1.PrintInfo();
                    p2.PrintInfo();
                }
                else
                    if (p3.GetAge() > p2.GetAge())
                    {
                        p1.PrintInfo();
                        p2.PrintInfo();
                        p3.PrintInfo();
                    }
                    else
                    {
                        p1.PrintInfo();
                        p3.PrintInfo();
                        p2.PrintInfo();
                    }
            */
        }

    }
}
