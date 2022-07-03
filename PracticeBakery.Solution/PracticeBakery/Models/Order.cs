using System.Collections.Generic;
using System;
using PracticeBakery.Models;

namespace PracticeBakery.Models
{
  public class Order
  {
    // auto implemented properties
    private BreadOrder _breadOrder;
    private PastryOrder _pastryOrder;
    // constructor

    public Order()
    {
      BreadOrder BreadOrder = _breadOrder;
      PastryOrder PastryOrder = _pastryOrder;
    }

    // methods
  }
}