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
      RepeatCounter newRepeatCounter = new RepeatCounter("test","test");
      Assert.AreEqual(typeof(RepeatCounter), newRepeatCounter.GetType());

    }

    [TestMethod]
    public void Count_CountsTheWordInTheSentence_Int()
    {
      //Arrange
      RepeatCounter newRepeatCounter = new RepeatCounter("cat", "I am struggling cat cat");

      //Act
      int expectedCount = 2;
      int actualCount = newRepeatCounter.Count();

      //Assert
      Assert.AreEqual(expectedCount, actualCount);
    }

  }
}
