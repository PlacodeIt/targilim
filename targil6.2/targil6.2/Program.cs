

//targil 2
{
    int winner = 0;
    bool w = true;
    int[] parties = new int[6];

    while (w)
    {
        int tie = 0;// tie =1, there is a winner; tie >1, there is a real tie
        int maxVotes = 0;


        string userInput = Console.ReadLine();
        switch (userInput)
        {
            case "-1": break;
            case "1": parties[0]++; continue;
            case "2": parties[1]++; continue;
            case "3": parties[2]++; continue;
            case "4": parties[3]++; continue;
            case "5": parties[4]++; continue;
            case "6": parties[5]++; continue;
        }
        Console.WriteLine("\n");
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(parties[i]);
        }

        for (int i = 0; i < 6; i++)
        {
            if (parties[i] >= maxVotes && parties[i] != 0)
            {
                maxVotes = parties[i];
                winner = i + 1;
            }
        }
        for (int i = 0; i < 6; i++)
        {
            if (parties[i] == maxVotes)
            {
                tie++;
            }
        }

        if (tie == 1)
        {
            w = false;
        }
        else
        {
            Console.WriteLine("no winning party, go to another election round\n ");
            for (int i = 0; i < 6; i++)
            {
                parties[i] = 0;
            }
        }

    }
    Console.WriteLine("\nwinner");
    Console.WriteLine(winner);
}




