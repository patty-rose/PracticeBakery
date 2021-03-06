using System.Collections.Generic;
using System;
using PracticeBakery.Models;

namespace PracticeBakery.Models
{
  public class Order
  {
    // auto implemented properties
    public BreadOrder BreadOrder { get; set; }
    public PastryOrder PastryOrder { get; set; }
    // constructor

    public Order()
    {
      BreadOrder = BreadOrder;
      PastryOrder = PastryOrder;
    }

    // methods

    public int CalculateOrderTotal()
    {
      int breadTotal = BreadOrder.BreadCost();
      int pastryTotal = PastryOrder.PastryCost();
      return breadTotal + pastryTotal;
    }
  }
}