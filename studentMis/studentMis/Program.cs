namespace studentMis
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    int count = 0;
        //    double sum = 0, highPay = 0, lowPay = 1555555555;
        //    while (true)
        //    {

        //       Console.WriteLine("Enter First name: ");
        //        string firstName = Console.ReadLine();
        //        if (firstName == "end")
        //        {
        //            break;
        //        }  
        //        Console.WriteLine("Enter Last name: ");
        //        string lastName = Console.ReadLine();
        //        Console.WriteLine("Enter ID: ");
        //        string id = Console.ReadLine();
        //        Console.WriteLine("Enter Points: ");
        //        int points = Convert.ToInt32(Console.ReadLine());
        //        Student student = new Student(firstName, lastName, id, points);
        //        double pay = student.CalculatePayment();
        //        if (pay > highPay)
        //        {
        //            highPay = pay;
        //        }
        //        else if (pay < lowPay)
        //        {
        //            lowPay = pay;   
        //        }
        //        sum += pay;
        //        count++;
        //    }  
        //    double avg = sum / count;
        //    Console.WriteLine("The avarage paymeant is: " + avg);
        //    Console.WriteLine("The high pay is: " + highPay);
        //    Console.WriteLine("The Lowe pay is: " + lowPay);

        //}  

        public static void Main(string[] args)
        {
            double sum = 0;
            GradeBook gradeBook = new GradeBook();
            for (int i = 0; i < 3; i++)
            {
                gradeBook.SetStudent();
                Student student = gradeBook.GetStudent();
                double avg = student.CalculateGrades();
                sum += avg;
                gradeBook.PrintInfo();
            }
            double avgTotal = sum / 3;
            Console.WriteLine("The avg is: " + avgTotal);
        }
    }
}