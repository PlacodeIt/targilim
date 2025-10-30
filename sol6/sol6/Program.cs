// See https://aka.ms/new-console-template for more information
//ex1
const int ARR_SIZE = 5;
const int MAX_NUM = 10;
double[] nums = new double[ARR_SIZE];
double[] numsLarge = new double[ARR_SIZE];
int numsLargeSize = 0;
for (int i = 0; i < nums.Length;)
{
    Console.WriteLine("Please enter a decimal number");
    if (double.TryParse(Console.ReadLine(), out nums[i]))
    {
        if (nums[i] > MAX_NUM)
        {
            numsLarge[numsLargeSize] = nums[i];
            numsLargeSize++;

        }
        i++;
    }
    else
    {
        Console.WriteLine("wrong input, try again");
    }

}
if (numsLargeSize == 0)
{
    Console.WriteLine("all the numbers were smaller than 10");
}
else
{
    //double[] numsLarge = new double[numsLargeSize];//an alternative option of the program implementation is to create and fill in this array here
    Console.WriteLine("all numbers");
    for (int i = 0; i < nums.Length; i++)
        Console.WriteLine(nums[i]);
    Console.WriteLine("numbers larger than 10:");
    for (int i = 0; i < numsLargeSize; i++)
        Console.WriteLine(numsLarge[i]);
}

//ex2
const int PARTY_NUM = 6;

while (true)
{
    int[] votes = new int[PARTY_NUM];
    int[] winner = new int[PARTY_NUM];
    int winnerVal = 0;

    while (true)
    {
        Console.WriteLine("Enter vote:");

        if (!int.TryParse(Console.ReadLine(), out int vote))
            continue;
        if (vote == -1)
            break;
        switch (vote)
        {
            case 1: votes[0]++; break;
            case 2: votes[1]++; break;
            case 3: votes[2]++; break;
            case 4: votes[3]++; break;
            case 5: votes[4]++; break;
            case 6: votes[5]++; break;
            default: Console.WriteLine("No such party, try again."); break;
        }
    }

    for (int i = 0; i < votes.Length; i++)
    {
        Console.WriteLine((i + 1) + " appeared " + votes[i] + " times.");
        if (winnerVal < votes[i])
            winnerVal = votes[i];
    }
    int j = 0; // winners' counter
    for (int i = 0; i < votes.Length; i++)
    {
        if (winnerVal == votes[i])
        {
            winner[j] = i + 1;
            Console.WriteLine("The winning party is " + (i + 1));
            j++;
        }

    }
    if (j == 1) break;
    Console.WriteLine("No winning party. Go to another election round!");
}


