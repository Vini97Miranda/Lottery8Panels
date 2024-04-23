using System;
using System.Collections.Generic;
using System.Linq;


class LotteryTicket
{
    private List<Panel> panels;

    public LotteryTicket()
    {
        panels = new List<Panel>();
    }

    public void AddPanel(Panel panel)
    {
        panels.Add(panel);
    }

    public double CalculateCost()
    {
        return panels.Count * Panel.CostPerPanel;
    }

    public bool CheckWinningPanel(int[] winningNumbers)
    {
        foreach (var panel in panels)
        {
            if (panel.CheckWinningCombination(winningNumbers))
            {
                return true;
            }
        }
        return false;
    }
}