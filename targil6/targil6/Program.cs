//TARGIL 1




using System;

namespace targil24041
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                int counter = 0;
                int i = 0;
                double[] a = new double[5];
                double[] b = new double[5];

                for (i = 0; i < 5; i++)// creating a
                {
                    a[i] = double.Parse(Console.ReadLine());
                }
                for (i = 0; i < 5; i++)// creating b
                {
                    if (a[i] >= 10)
                    {
                        b[counter] = a[i];
                        counter++;
                    }
                }
                //printing a&b
                Console.WriteLine("\n");
                for (i = 0; i < 5; i++)
                {
                    Console.WriteLine(a[i]);
                }
                Console.WriteLine("\n");
                for (i = 0; i < 5; i++)
                {
                    if (b[i] != 0)
                    {
                        Console.WriteLine(b[i]);
                    }
                }
            }






        }
    }
}










