using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using PracticeBakery.Models;

namespace PracticeBakery.Tests
{
  [TestClass]
  public class PastryOrderTests
  {
    [TestMethod]
    public void PastryOrderConstructor_CreatesInstanceOfPastryOrder_PastryOrder()
    {
      PastryOrder newPastryOrder = new PastryOrder(0);
      Assert.AreEqual(typeof(PastryOrder), newPastryOrder.GetType());
    }

    [TestMethod]
    public void PastryCost_CalculateCostOfPastriesOrdered_4()
    {
      PastryOrder newPastryOrder = new PastryOrder(2);
      Assert.AreEqual(4, newPastryOrder.PastryCost());
    }

    [TestMethod]
    public void PastryCost_CalculateCostOfBuyTwoGetOneHalfOffOrder_10()
    {
      PastryOrder newPastryOrder = new PastryOrder(6);
      Assert.AreEqual(10, newPastryOrder.PastryCost());
    }
  }
}