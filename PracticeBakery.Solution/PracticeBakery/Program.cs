using System;
using System.Collections.Generic;
using PracticeBakery.Models;

namespace PracticeBakery.Models
{
  public class Program
  {
    static void Main()
    {
      Order currentOrder = new Order();
      Console.WriteLine("---------------------------");
      Console.WriteLine("---------------------------");
      Console.WriteLine("Welcome to Patty's Practice Bakery!");
      Console.WriteLine("------------------MENU------------------");
      Console.WriteLine("Bread --- $5/each *buy 2 get 1 free");
      Console.WriteLine("Pastry -- $2/each *buy 3 for $5");
      Console.WriteLine("----------------------------------------");
      UserNavigation(currentOrder);
      
      // Console.WriteLine("---------------------------");
      // Console.WriteLine("----Your-Receipt-From------");
      // Console.WriteLine("--Patty's-Practice-Bakery--");
      // Console.WriteLine("---------------------------");
      // Console.WriteLine("---------------------------");
      // Console.WriteLine(currentBreadOrder.OrderedBreads + " breads --------------$" + currentBreadCost);
      // Console.WriteLine(userInputPastry + " pastries ------------$" + currentPastryCost);
      // Console.WriteLine("------------------Total:$" + (currentBreadCost + currentPastryCost));
      // Console.WriteLine("---------------------------");
      // Console.WriteLine("-----Have-A-Nice-Day!------");
      // Console.WriteLine("---------------------------");
    }
    static void UserNavigation(Order order)
    {
      Console.WriteLine("Would you like to:");
      Console.WriteLine("1) order bread");
      Console.WriteLine("2) order pastries");
      Console.WriteLine("3) see order total");
      Console.WriteLine("Please type your selection 1, 2, or 3 and press enter");
      string choice = Console.ReadLine();
      if (choice == "1")
      {
        BreadInterface(order);
      }
      else if (choice == "2")
      {
        PastryInterface(order);
      } 
      else if (choice == "3")
      {
        // run total function
      }
      else
      {
        Console.WriteLine("You did not enter a valid option. Please enter 1 to order bread, 2 to order pastries, and 3 to see order total.");
        UserNavigation(order);
      }
    }

    static void BreadInterface(Order order)
    {
      Console.WriteLine("We offer in-house baked sourdough bread made fresh every morning.");
      Console.WriteLine("1 loaf for $5 or 3 loaves for $10");
      Console.WriteLine("How many loaves of bread would you like to order? (please enter a number 0-50)");
      int userInputBread = Convert.ToInt32(Console.ReadLine());
      if (userInputBread >= 0 && userInputBread <= 50)
      {
      order.BreadOrder = new BreadOrder(userInputBread);
      int currentBreadCost = order.BreadOrder.BreadCost();
      Console.WriteLine(userInputBread + " breads will cost " + currentBreadCost + " dollars.");
      Console.WriteLine("current orderedBreads in order class: " +  order.BreadOrder.OrderedBreads);
      UserNavigation(order);
      }
      else
      {
        Console.WriteLine("I'm sorry, we can only accept orders of bread between 0 and 50 loaves. Please try again.");
        BreadInterface(order);
      }
    }

    static void PastryInterface(Order order)
    {
      Console.WriteLine("We offer in-house baked bear claws made fresh every morning.");
      Console.WriteLine("1 pastry for $2 or 3 pastries for $5");
      Console.WriteLine("How many pastries would you like to order? (please enter a number 0-50)");
      int userInputPastry = Convert.ToInt32(Console.ReadLine());
      if (userInputPastry >= 0 && userInputPastry <= 50)
      {
      order.PastryOrder = new PastryOrder(userInputPastry);
      int currentPastryCost = order.PastryOrder.PastryCost();
      Console.WriteLine(userInputPastry + " pastries will cost " + currentPastryCost + " dollars.");
      Console.WriteLine("current orderedPastries in order class: " +  order.PastryOrder.OrderedPastries);
      UserNavigation(order);
      }
      else
      {
        Console.WriteLine("I'm sorry, we can only accept orders of pastries between 0 and 50. Please try again.");
        PastryInterface(order);
      }
    }
  }
}