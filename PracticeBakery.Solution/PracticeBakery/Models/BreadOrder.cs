using System.Collections.Generic;
using System;
using PracticeBakery.Models;

namespace PracticeBakery.Models
{
  public class BreadOrder
  {
    // auto implemented properties
    public int OrderedBreads { get; set; }

    // constructor
    public BreadOrder(int orderedBreads)
    {
      OrderedBreads = orderedBreads;
    }

    // methods

    public int BreadCost()
    {
      int cost = 0;
      int freeBreads = OrderedBreads / 3;
      cost = (OrderedBreads - freeBreads) * 5;
      return cost;
    }
  }
}