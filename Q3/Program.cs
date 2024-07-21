int bish = 0;
int bosh = 0;
int bash = 0;
int bishbashbosh = 0;
int bishbash= 0;

for (int i = 0; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0 && isEven(i.ToString()) % 2 == 1)
    {
        bishbashbosh++;
    }
    else if (i % 3 == 0 && i % 5 == 0)
    {
        bishbash++;
    }
    else if (i % 3 == 0)
    {
        bish++;
    }
    else if (i % 5 == 0)
    {
        bash++;

    }

    else if (isEven(i.ToString()) % 2 == 1)
    {
        bosh++;
    }

}

int isEven(string number)
{
    int isEven = 0;
    foreach (char c in number)
    {
        isEven += c - '0';
    }return isEven;
}

Console.WriteLine($"{bish} Bish ");
Console.WriteLine($"{bash} Bash ");
Console.WriteLine($"{bosh} Bosh ");
Console.WriteLine($"{bishbash} BishBASH ");
Console.WriteLine($"{bishbashbosh} BishBashBosh ");