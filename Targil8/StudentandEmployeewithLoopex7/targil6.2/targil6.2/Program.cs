using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Targil5_2NEW
{
    class Program
    {
        static void Main(string[] args)
        {
            double max = 0, min = 0,sum=0;
            int count = 0;
            while (true)
            {
                Console.WriteLine("please enter student details: first name, last name ,ID ,and academic points");
                string fName = Console.ReadLine().Trim();
                if (fName == "-1")
                    break;
                string lName = Console.ReadLine().Trim();
                string ID = Console.ReadLine().Trim();
                
                int points = 0;
                if (!int.TryParse(Console.ReadLine(), out points) || fName == "" || lName == "" ||
                    ID == "" || !int.TryParse(ID, out int id))
                {
                    Console.WriteLine("wrong input");
                    continue;
                }

                Student s1 = new Student(fName,lName,ID,points);
                double num = s1.NeedToPay();
                if (num == -1)
                {
                    Console.WriteLine("something went wrong, try again");
                    continue;
                }
                if (count == 0)
                {
                    max = num;
                    min = num;
                }
                else
                {
                    if (num < min)
                        min = num;
                    if (num > max)
                        max = num;
                }
                count++;
                
                //Console.WriteLine(num);
                sum += num;

            }
            Console.WriteLine("The minimum tuition fee is " + min);
            Console.WriteLine("The maximum tuition fee is " + max);
            if (count != 0)
                Console.WriteLine("The average tuition fee is " + ((double)sum) / count);
            else
                Console.WriteLine("There were no valid students entered");
            Console.ReadKey();
        }
    }
}
