using System;

namespace Persons
{
    class Person
    {
        //attributes
        string _name;
        int _age;
        double _height;
        //constructor
        Person (string name, int age, double height)
        {
            _name = name;
            _age = age;
            _height = height;
        }
        //methods
        void PrintInfo()
        {
            Console.WriteLine(_name + " " + _age + " " + _height);
        }

        void SetName(string name)
        {
            _name = name;
        }

        void SetAge(int age)
        {
            _age = age;
        }

        void setHeight(double height)
        {
            _height = height;
        }

        string getName()
        {
            return _name;
        }

        int getAge()
        {
            return _age;
        }

        double getHeight()
        {
            return _height;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p = new Person("moshe", 25, 1.6);
            p.PrintInfo();
            string name = p.getName();
            int age = p.getAge();
            Console.WriteLine("name and age: " + name + " " + age);
            int a = 45;
            p.SetAge(a);
            p.PrintInfo();
        }
    }
}
