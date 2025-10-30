// See https://aka.ms/new-console-template for more information
//ex1
const int ARR_SIZE = 5;
int[] numbers = new int[ARR_SIZE];
int sum = 0;

for (int i = 0; i < numbers.Length;)
{
    Console.WriteLine("Please enter an integer number");
    //TryParse gets a string as a first argument, tries to convert it, stores the result in the second argument and returns true if succeeded or false if did not 
    if (int.TryParse(Console.ReadLine(), out numbers[i])==true) //check if the input is a number
    {
        sum += numbers[i];
        i++;
    }
    else //if the input is not a number, parse failed
    {
        Console.WriteLine("wrong input, try again");
    }
    
}
double average = ((double)sum) / numbers.Length;
Console.WriteLine("average: " + average);
sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i] * numbers[i];
}
average = ((double)sum) / numbers.Length;
Console.WriteLine("average: " + average);


//ex2 - the calculator
Console.WriteLine("Please enter the first number");
string num = Console.ReadLine();
double num1;
while (!double.TryParse(num, out num1))
{
    if (num == "end")
    {
        Console.WriteLine("Bye!");
        break;
    }
    Console.WriteLine("wrong input, please enter a number");
    num = Console.ReadLine();
}
if (num != "end")
{
    double res = num1;
    while (true)
    {
        Console.WriteLine("Please enter the operation to compute");
        string sign = Console.ReadLine();
        if (sign == "end")
        {
            Console.WriteLine("Bye");
            break;
        }
        if (sign != "+" && sign != "-" && sign != "*" && sign != "/")
        {
            Console.WriteLine("wrong operator, try again");
            continue;
        }
        Console.WriteLine("Please enter the number");
        double num2;
        string snum2 = Console.ReadLine();
        while (!double.TryParse(snum2, out num2))
        {
            if (snum2 == "end")
            {
                Console.WriteLine("Bye");
                break;
            }
            Console.WriteLine("Wrong input, please enter a number");
            snum2 = Console.ReadLine();
        }
        if (snum2 != "end")
        {
            switch (sign)
            {
                case "+": res += num2; break;
                case "-": res -= num2; break;
                case "*": res *= num2; break;
                case "/":
                    if (num2 != 0)
                        res /= num2;
                    else
                        Console.WriteLine("wrong number, should not be 0");
                    break;
                default: Console.WriteLine("wrong operator"); break;
            }
        }
        else break;
    }

    Console.WriteLine("Result: " + res);
}


//lesson 7 class exercises
//ex1 - search moshe cohen in the array of students and print his grades
//const int MAX_ARR_SIZE = 5;
const string NAME = "moshe cohen";
/*const string NAME = "moshe cohen";

Console.WriteLine("search moshe cohen in the array of students and print his grades");

string[] students = new string[MAX_ARR_SIZE];

int[] grades = new int[MAX_ARR_SIZE];
int count = 0;
for (int i = 0; i < MAX_ARR_SIZE; i++)
{
    Console.WriteLine("please enter a student's name and ave grade");
    string stud = Console.ReadLine();

    if (stud == "-1")
    {
        Console.WriteLine("end of input");
        break;
    }

    if (!int.TryParse(Console.ReadLine(), out grades[i]) || grades[i] > 100 || grades[i] < 0)
    {
        Console.WriteLine("wrong grade, try again");
        i--;
        continue;
    }
    students[i] = stud;
    count++;

}

int j;
for (j = 0; j < count; j++)
{

    if (students[j].ToLower() == NAME)
    {
        Console.WriteLine("Moshe Cohen's ave grade is: " + grades[j]);
        break;
    }


}
if (j == count)
    Console.WriteLine("not found");
*/
//lesson 7 in class example
//ex1 search a number in the array,
//create a new array with indices of the occurrences of the number in the original array,
//print the indices array, replace all the occurrence of the number with -1
//and print the original array

//Fill in an unordered array with numbers.
const int MAX_ARR_SIZE = 5;
int[] data = new int[MAX_ARR_SIZE];

Console.WriteLine("Enter " + MAX_ARR_SIZE + " numbers: ");
for (int i = 0; i < MAX_ARR_SIZE;)
{
    //data[i] = int.Parse(Console.ReadLine());
    if (!int.TryParse(Console.ReadLine(), out data[i]))
    {
        Console.WriteLine("wrong input, try again");
        continue;
    }
    else i++;
}
//   Search the array if it is not empty, and print not found for an absent number.

int res_pos = 0;
Console.WriteLine("Enter a number to search.");
int[] results = new int[MAX_ARR_SIZE];
if (int.TryParse(Console.ReadLine(), out int numm))//check input is a number
{

    for (int pos = 0; pos < data.Length; pos++)
    {
        if (data[pos] == numm)
        {
            results[res_pos] = pos;
            res_pos++;
        }

    }
}
else
{
    Console.WriteLine("wrong input, should be a number");
}
//print the positions of the found number

if (res_pos == 0)
    Console.WriteLine("number not found");
else
{
    for (int i = 0; i < res_pos; i++)
    {
        Console.WriteLine("found the number " + numm + " at position: "
            + (results[i] + 1));
        //replace all the occurrences of num in the original array with -1
        //we run only on the positions of num
        data[results[i]] = -1;
    }

    Console.WriteLine("the data array is: ");
    for (int i = 0; i < data.Length; i++)
    {
        Console.WriteLine(data[i]);

    }
}

//copying an array by reference and by value, and printing the array

string[] a = new string[3];

for (int z = 0; z < a.Length; z++)
    a[z] = z.ToString();

//string[] b = a;
string[] b = new string[3];
for (int i = 0; i < a.Length; i++)
{
    Console.WriteLine(a[i] + ", " + b[i]);
}
for (int i = 0; i < a.Length; i++)
{
    b[i] = a[i];
}
a.CopyTo(b, 0);
//Console.WriteLine(a + " " + b);
a[1] = "2";
for (int i = 0; i < a.Length; i++)
{
    Console.WriteLine(a[i] + ", " + b[i]);
}
string str = string.Join(",", a);
Console.WriteLine(str);
string w = "this is array";
a = w.Split(" ");
for (int i = 0; i < a.Length; i++)
{
    Console.WriteLine(a[i]);
    //Console.WriteLine(b[i]);
}


//ex3 - get a sequence of numbers in one line and calculate their min, max and average

Console.WriteLine("please enter a sequence of 5 numbers in one line with a white space between them");
string seq = Console.ReadLine();

string[] nums = seq.Split(" ");
if (nums.Length != MAX_ARR_SIZE)
    Console.WriteLine("wrong input, bye");
else
{
    double summ = 0;
    if (int.TryParse(nums[0], out int nummm))
    {
        int min = nummm;
        int max = nummm;
        sum = nummm;
        for (int i = 1; i < MAX_ARR_SIZE; i++)
        {
            if (int.TryParse(nums[i], out int n))
            {
                summ += n;
                if (min > n)
                    min = n;
                if (max < n)
                    max = n;
            }
            else
            {
                Console.WriteLine("wrong input, bye");
                break;
            }
        }
        double ave = summ / MAX_ARR_SIZE;
        Console.WriteLine("Average: " + ave + " max: " + max + " min: " + min);
    }
    else Console.WriteLine("wrong input, bye");
}

//ex2 - optional - version 2 of ex1 with split and foreach - get a student's name and ave grade in one line and searches for moshe cohen and prints his grade
Console.WriteLine("ex2 with split");

string [] students = new string[MAX_ARR_SIZE];

for (int i = 0; i < MAX_ARR_SIZE; i++)
{
    Console.WriteLine("please enter a student's name and ave grade in one line with a comma as a delimiter");
    students[i] = Console.ReadLine();
    if (students[i] == "-1")
    {
        break;
    }
}
bool found = false;
foreach (string st in students)
{
    if (st == "-1")
        break;
    string[] arr = st.Split(',');
    if (arr.Length != 2)
        break;
    if (arr[0] == NAME)
    {
        if (int.TryParse(arr[1], out int g1))
        {
            Console.WriteLine("Moshe Cohen's ave grade is: " + arr[1]);
            found = true;
            break;
        }
        else
        {
            Console.WriteLine("wrong grade");
            break;
        }
    }

}
if (!found)
    Console.WriteLine("not found");



