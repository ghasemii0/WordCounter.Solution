// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using WordCounterModels;
// using System;
// using System.Collections.Generic;
//
// namespace WordCounterTests
// {
//         [TestClass]
//     public class WordCounterTests
//     {
//         [TestMethod]
//         public void RepeatCounterConstructor_CreateObjectInstance_RepeatCounter()
//         {
//             RepeatCounter newRepeatCounter = new RepeatCounter("test");
//             Assert.AreEqual(typeof(RepeatCounter), newRepeatCounter.GetType());
//         }
//          [TestMethod]
//         public void GetTargetWord_ReturnsTargetWord_String()
//         {
//             string targetWord = "cat";
//             RepeatCounter newRepeatCounter = new RepeatCounter("cat");
//
//             string result = newRepeatCounter.GetTargetWord();
//             Assert.AreEqual(targetWord, result);
//         }
//     }
// }














using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCountModel;

namespace WordCountTests
{
  [TestClass]
  public class WordCountTest
  {
    [TestMethod]
    public void RepeatCounterConstructor_CreateObjectInstance_RepeatCounter()
    {
        RepeatCounter newRepeatCounter = new RepeatCounter("test");
        Assert.AreEqual(typeof(RepeatCounter), newRepeatCounter.GetType());

    }
  }
}
