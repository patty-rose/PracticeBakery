using System;
using System.Collections.Generic;
using PracticeBakery.Models;

namespace PracticeBakery.Models
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Patty's Practice Bakery!");
      Console.WriteLine("------------------MENU------------------");
      Console.WriteLine("Bread --- $5/each *buy 2 get 1 free");
      Console.WriteLine("Pastry -- $2/each *buy 3 for $5");
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("How many breads would you like to order?");
      int currentOrderedBread = Convert.ToInt32(Console.ReadLine());
      BreadOrder currentBreadOrder = new BreadOrder(currentOrderedBread);
      int currentBreadCost = currentBreadOrder.BreadCost();
      Console.WriteLine(currentOrderedBread + " breads will cost " + currentBreadCost + " dollars.");
    }
  }
}