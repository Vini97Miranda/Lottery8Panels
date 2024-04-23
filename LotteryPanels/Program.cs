using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        // Test the functionality
        LotteryTicket ticket = new LotteryTicket();

        // Create panels
        Panel panel1 = new Panel();
        panel1.AddQuickPick();
        ticket.AddPanel(panel1);

        Panel panel2 = new Panel();
        panel2.AddNumber(1);
        panel2.AddNumber(2);
        panel2.AddNumber(3);
        panel2.AddNumber(4);
        panel2.AddNumber(5);
        panel2.AddNumber(6);
        ticket.AddPanel(panel2);

        Panel panel3 = new Panel();
        panel3.AddNumber(7);
        panel3.AddNumber(8);
        panel3.AddNumber(9);
        panel3.AddNumber(10);
        panel3.AddNumber(11);
        panel3.AddNumber(12);
        ticket.AddPanel(panel3);

        // Generate winning numbers
        int[] winningNumbers = GenerateRandomNumbers(Panel.NumbersPerPick);

        // Check if user has a winning panel
        bool isWinner = ticket.CheckWinningPanel(winningNumbers);

        // Output the cost of the lottery ticket
        Console.WriteLine($"Cost of the lottery ticket: {ticket.CalculateCost()} euro");
        Console.WriteLine($"Are winning numbers: {string.Join(", ", winningNumbers)}");
        Console.WriteLine($"Is winner: {isWinner}");
    }

    static int[] GenerateRandomNumbers(int count)
    {
        Random rand = new Random();
        List<int> numbers = new List<int>();

        while (numbers.Count < count)
        {
            int randomNumber = rand.Next(1, Panel.NumbersPerPanel + 1);
            if (!numbers.Contains(randomNumber))
            {
                numbers.Add(randomNumber);
            }
        }

        return numbers.ToArray();
    }
}

