using System;
using System.Collections.Generic;
using PracticeBakery.Models;

namespace PracticeBakery.Models
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("---------------------------");
      Console.WriteLine("---------------------------");
      Console.WriteLine("Welcome to Patty's Practice Bakery!");
      Console.WriteLine("------------------MENU------------------");
      Console.WriteLine("Bread --- $5/each *buy 2 get 1 free");
      Console.WriteLine("Pastry -- $2/each *buy 3 for $5");
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("How many breads would you like to order?");
      int userInputBread = Convert.ToInt32(Console.ReadLine());
      BreadOrder currentBreadOrder = new BreadOrder(userInputBread);
      int currentBreadCost = currentBreadOrder.BreadCost();
      Console.WriteLine(userInputBread + " breads will cost " + currentBreadCost + " dollars.");
      Console.WriteLine("How many pastries would you like to order?");
      int userInputPastry = Convert.ToInt32(Console.ReadLine());
      PastryOrder currentPastryOrder = new PastryOrder(userInputPastry);
      int currentPastryCost = currentPastryOrder.PastryCost();
      Console.WriteLine(userInputPastry + " pastries will cost " + currentPastryCost + " dollars.");
      Console.WriteLine("---------------------------");
      Console.WriteLine("----Your-Receipt-From------");
      Console.WriteLine("--Patty's-Practice-Bakery--");
      Console.WriteLine("---------------------------");
      Console.WriteLine("---------------------------");
      Console.WriteLine(userInputBread + " breads --------------$" + currentBreadCost);
      Console.WriteLine(userInputPastry + " pastries ------------$" + currentPastryCost);
      Console.WriteLine("------------------Total:$" + (currentBreadCost + currentPastryCost));
      Console.WriteLine("---------------------------");
      Console.WriteLine("-----Have-A-Nice-Day!------");
      Console.WriteLine("---------------------------");
    }
  }
}