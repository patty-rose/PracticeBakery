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
  }
}