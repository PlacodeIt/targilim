using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Targil6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0, count = 0;
            while (true)
            {
                Console.WriteLine("please enter employee details in the following order :first name, last name, ID, hascala, and vetek.");
                string fName = Console.ReadLine().Trim();
                if (fName == "-1")
                    break;
                string lName = Console.ReadLine().Trim();
                string ID = Console.ReadLine().Trim();
                string hascala = Console.ReadLine().Trim();
                int vetek = 0;
                if (!int.TryParse(Console.ReadLine(), out vetek) || fName =="" || lName=="" || 
                    ID=="" || !int.TryParse(ID, out int id) || hascala=="")
                {
                    Console.WriteLine("wrong input");
                    continue;
                }

                Employee myEmployee = new Employee(fName, lName, ID, hascala, vetek);
                int num = myEmployee.calculate();
                if (num <= 0)
                {
                    Console.WriteLine("something went wrong, try again");
                    continue;
                }
                //Console.WriteLine(num);
                sum += num;
                count++;

            }
            if (count > 0)
                Console.WriteLine("The average salary is: " + ((double) sum) / count);
            else
                Console.WriteLine("There were no valid employees entered");
            Console.ReadKey();
        }
    }
}
