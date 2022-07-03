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
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("Welcome to Patty's Practice Bakery!");
      UserNavigation(currentOrder);
    }

    static void UserNavigation(Order order)
    {
      Console.WriteLine("------------------------------------------------------");
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
        GetTotal(order);
      }
      else
      {
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("You did not enter a valid option. Please enter 1 to order bread, 2 to order pastries, or3 to see order total");
        UserNavigation(order);
      }
    }

    static void BreadInterface(Order order)
    {
      if (order.BreadOrder is BreadOrder)
      {
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("Currently, you have ordered:");
        Console.WriteLine(order.BreadOrder.OrderedBreads + " loaves of bread totaling  $" + order.BreadOrder.BreadCost());
        Console.WriteLine("You are changing your bread order-- how many loaves of bread would you like to change your order to? (please enter a number 0-50)");
        int userInputBread = Convert.ToInt32(Console.ReadLine());
        if (userInputBread >= 0 && userInputBread <= 50)
        {
          order.BreadOrder.OrderedBreads = userInputBread;
          Console.WriteLine("------------------------------------------------------");
          Console.WriteLine("Your bread order has been changed to " + order.BreadOrder.OrderedBreads + " totaling $" + order.BreadOrder.BreadCost());
          UserNavigation(order);
        }
        else
        {
          Console.WriteLine("------------------------------------------------------");
          Console.WriteLine("I'm sorry, we can only accept orders of bread between 0 and 50 loaves. Please enter a number between 0 and 50.");
          BreadInterface(order);
        }
      } 
      else
      {
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("We offer in-house baked sourdough bread made fresh every morning.");
        Console.WriteLine("1 loaf for $5 or 3 loaves for $10");
        Console.WriteLine("How many loaves of bread would you like to order? (please enter a number 0-50)");
        int userInputBread = Convert.ToInt32(Console.ReadLine());
        if (userInputBread >= 0 && userInputBread <= 50)
        {
          order.BreadOrder = new BreadOrder(userInputBread);
          int currentBreadCost = order.BreadOrder.BreadCost();
          Console.WriteLine("------------------------------------------------------");
          Console.WriteLine("You have ordered " + userInputBread + " loaves of bread.");
          Console.WriteLine(userInputBread + " loaves of bread will cost " + currentBreadCost + " dollars.");
          UserNavigation(order);
        }
        else
        {
          Console.WriteLine("------------------------------------------------------");
          Console.WriteLine("I'm sorry, we can only accept orders of bread between 0 and 50 loaves. Please enter a number between 0 and 50.");
          BreadInterface(order);
        }
      }
    }

    static void PastryInterface(Order order)
    {
      if (order.PastryOrder is PastryOrder)
      {
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("Currently, you have ordered:");
        Console.WriteLine(order.PastryOrder.OrderedPastries + " pastries totaling  $" + order.PastryOrder.PastryCost());
        Console.WriteLine("You are changing your Pastry order-- how many pastries would you like to change your ordere to? (please enter a number 0-50)");
        int userInputPastry = Convert.ToInt32(Console.ReadLine());
        if (userInputPastry >= 0 && userInputPastry <= 50)
        {
          order.PastryOrder.OrderedPastries = userInputPastry;
          Console.WriteLine("------------------------------------------------------");
          Console.WriteLine("Your Pastry order has been changed to " + order.PastryOrder.OrderedPastries + " totaling $" + order.PastryOrder.PastryCost());
          UserNavigation(order);
        }
        else
        {
          Console.WriteLine("------------------------------------------------------");
          Console.WriteLine("I'm sorry, we can only accept orders of pastries between 0 and 50. Please enter a number between 0 and 50.");
          PastryInterface(order);
        }
      } 
      else
      {
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("We offer in-house baked bear claws made fresh every morning.");
      Console.WriteLine("1 pastry for $2 or 3 pastries for $5");
      Console.WriteLine("How many pastries would you like to order? (please enter a number 0-50)");
      int userInputPastry = Convert.ToInt32(Console.ReadLine());
      if (userInputPastry >= 0 && userInputPastry <= 50)
      {
      order.PastryOrder = new PastryOrder(userInputPastry);
      int currentPastryCost = order.PastryOrder.PastryCost();
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("You have ordered " + userInputPastry + " pastries.");
      Console.WriteLine(userInputPastry + " pastries will cost " + currentPastryCost + " dollars.");
      UserNavigation(order);
      }
      else
      {
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("I'm sorry, we can only accept orders of pastries between 0 and 50. Please enter a number between 0 and 50.");
        PastryInterface(order);
      }
      }
      
    }

    static void GetTotal(Order order)
    {
      if (order.BreadOrder is BreadOrder || order.PastryOrder is PastryOrder)
      {
        if (!(order.BreadOrder is BreadOrder))
        {
          order.BreadOrder = new BreadOrder(0);
        }
        else if (!(order.PastryOrder is PastryOrder))
        {
          order.PastryOrder = new PastryOrder(0);
        }
        int currentTotal = order.CalculateOrderTotal();
        Console.WriteLine("---------------------------");
        Console.WriteLine("----Your-Receipt-From------");
        Console.WriteLine("--Patty's-Practice-Bakery--");
        Console.WriteLine("---------------------------");
        Console.WriteLine("---------------------------");
        Console.WriteLine(order.BreadOrder.OrderedBreads + " breads --------------$" + order.BreadOrder.BreadCost());
        Console.WriteLine(order.PastryOrder.OrderedPastries + " pastries ------------$" + order.PastryOrder.PastryCost());
        Console.WriteLine("------------------Total:$" + (currentTotal));
        Console.WriteLine("---------------------------");
        Console.WriteLine("-----Have-A-Nice-Day!------");
        Console.WriteLine("---------------------------");
        Console.WriteLine("Would you like to return to the menu? (YES/NO)");

        if (Console.ReadLine().ToUpper() == "YES")
        {
          UserNavigation(order);
        }
        else if (Console.ReadLine().ToUpper() == "NO")
        {
          Console.WriteLine("------------------------------------------------------");
          Console.WriteLine("Thank you for visiting Patty's Practice Bakery! Have a nice day!");
        }
        else
        {
          Console.WriteLine("------------------------------------------------------");
          Console.WriteLine("Please enter YES to see the menu again or NO to end Patty's Practice Bakery application.");
          GetTotal(order);
        }
      }
      else
      {
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("It seems you haven't ordered anything yet. Please order bread and/or pastries to see a total!");
        UserNavigation(order);
      }
    }
  }
}