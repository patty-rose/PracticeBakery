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
  }
}