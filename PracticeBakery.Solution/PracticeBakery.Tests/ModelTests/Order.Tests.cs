using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using PracticeBakery.Models;

namespace PracticeBakery.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void CalculateOrderTotal_CalculatesOrderTotal_15()
    {
      Order newOrder = new Order();
      newOrder.BreadOrder = new BreadOrder(3);
      newOrder.PastryOrder = new PastryOrder(3);
      Assert.AreEqual(15, newOrder.CalculateOrderTotal());
    }
  }
}