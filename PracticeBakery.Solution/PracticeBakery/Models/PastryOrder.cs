using System.Collections.Generic;
using System;
using PracticeBakery.Models;

namespace PracticeBakery.Models
{
  public class PastryOrder
  {
    // auto implemented properties
    public int OrderedPastries { get; set; }

    // constructor
    public PastryOrder(int orderedPastries)
    {
      OrderedPastries = orderedPastries;
    }
    // methods
    public int PastryCost()
    {
      int cost = 0;
      int discountedPastries = OrderedPastries / 3;
      cost = ((OrderedPastries - discountedPastries) * 2) + discountedPastries * 1;
      return cost;
    }
  }
}