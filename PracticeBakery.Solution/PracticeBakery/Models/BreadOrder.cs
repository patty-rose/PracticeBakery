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
    //Bread: Buy 2, get 1 free (every 3rd loaf of bread is free.). A single loaf costs $5, two loaves costs $10, and three loaves cost $10.
    public int BreadCost()
    {
      int cost = 0;
      int freeBreads = OrderedBreads / 3;
      cost = (OrderedBreads - freeBreads) * 5;
      return cost;
    }
  }
}