using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using PracticeBakery.Models;

namespace PracticeBakery.Tests
{
  [TestClass]
  public class BreadOrderTests
  {
    [TestMethod]
    public void BreadOrderConstructor_CreatesInstanceOfBreadOrder_BreadOrder()
    {
      BreadOrder newBreadOrder = new BreadOrder(0);
      Assert.AreEqual(typeof(BreadOrder), newBreadOrder.GetType());
    }

    [TestMethod]
    public void BreadCost_CalculateCostOfBreadsOrdered_10()
    {
      BreadOrder newBreadOrder = new BreadOrder(2);
      Assert.AreEqual(10, newBreadOrder.BreadCost());
    }

    [TestMethod]
    public void BreadCost_CalculateCostOfBuyTwoGetOneOrder_10()
    {
      BreadOrder newBreadOrder = new BreadOrder(6);
      Assert.AreEqual(20, newBreadOrder.BreadCost());
    }
  }
}