using System;

class Program
{
    static void Main()
    {
        int bish = 0;
        int bosh = 0;
        int bash = 0;
        int bishbashbosh = 0;
        int bishbash = 0;

        for (int i = 0; i <= 100; i++)
        {
            bool isBish = i % 3 == 0;
            bool isBash = i % 5 == 0;
            bool isBosh = isSumOfDigitsOdd(i.ToString());

            if (isBish && isBash && isBosh)
            {
                bishbashbosh++;
            }
            else if (isBish && isBash)
            {
                bishbash++;
            }
            else if (isBish)
            {
                bish++;
            }
            else if (isBash)
            {
                bash++;
            }

            if (isBosh)
            {
                bosh++;
            }
        }

        Console.WriteLine($"{bish} Bish");
        Console.WriteLine($"{bash} Bash");
        Console.WriteLine($"{bosh} Bosh");
        Console.WriteLine($"{bishbash} BishBash");
        Console.WriteLine($"{bishbashbosh} BishBashBOSH");
    }

    static bool isSumOfDigitsOdd(string number)
    {
        int sum = 0;
        foreach (char c in number)
        {
            sum += c - '0';
        }
        return sum % 2 == 1;
    }
}

//bosh and bishbash are wrong