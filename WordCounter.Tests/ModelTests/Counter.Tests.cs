using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System;
using System.Collections.Generic;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void RepeatCounterConstructor_CreatesInstanceOfReapeatCounter_True();
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("test");
      Assert.AreEqual(typeof(RepeatCounter), newRepeatCounter.GetType());
    }
  }
}
