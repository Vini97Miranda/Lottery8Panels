using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Panel
{
    public const int NumbersPerPanel = 50;
    public const int NumbersPerPick = 6;
    public const double CostPerPanel = 2.0;

    private List<int> numbers;

    public Panel()
    {
        numbers = new List<int>();
    }

    public void AddNumber(int number)
    {
        if (numbers.Count < NumbersPerPick && !numbers.Contains(number))
        {
            numbers.Add(number);
        }
    }

    public void AddQuickPick()
    {
        // Generate and add random numbers
        Random rand = new Random();
        while (numbers.Count < NumbersPerPick)
        {
            int randomNumber = rand.Next(1, NumbersPerPanel + 1);
            if (!numbers.Contains(randomNumber))
            {
                numbers.Add(randomNumber);
            }
        }
    }

    public bool CheckWinningCombination(int[] winningNumbers)
    {
        foreach (var number in numbers)
        {
            if (!Array.Exists(winningNumbers, element => element == number))
            {
                return false;
            }
        }
        return true;
    }
}