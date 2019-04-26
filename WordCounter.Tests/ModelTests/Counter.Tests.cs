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
      RepeatCounter newRepeatCounter = new RepeatCounter();
      Assert.AreEqual(typeof(RepeatCounter), newRepeatCounter.GetType());

    }

    [TestMethod]
    public void SpliteTheSentence_DoesInputedSentenceSplit_True()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter();
      string[] expected = { "I", "am", "struggling" };
      string[] sentenceInput = newRepeatCounter.SpliteTheSentence("I am struggling");
      Assert.AreEqual(expected[0],sentenceInput[0]);
      Assert.AreEqual(expected[1],sentenceInput[1]);
      Assert.AreEqual(expected[2],sentenceInput[2]);
    }

    [TestMethod]
    public void SpliteTheSentence_DoesInputedSentenceSplit_False()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter();
      string[] expected = { "we", "am", "struggling" };
      string[] sentenceInput = newRepeatCounter.SpliteTheSentence("I am struggling");
      Assert.AreEqual(expected[1],sentenceInput[1]);

    }

    [TestMethod]
    public void Count_HowManyMatches_3()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter();
      string word = "cat";
      string[] sentenceInput = newRepeatCounter.SpliteTheSentence("I am struggling cat cat cat");
      Assert.AreEqual(3,newRepeatCounter.Count(word));
    }
  }
}
