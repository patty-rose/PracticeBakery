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
  }
}