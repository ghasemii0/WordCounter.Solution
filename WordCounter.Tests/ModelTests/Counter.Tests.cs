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
    [TestMethod]
    public void SpliteTheSentence_DoesInputedSentenceSplit_False();
    RepeatCounter newRepeatCounter = new RepeatCounter();
  }
}
