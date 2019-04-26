namespace WordCountModel
{
  public class RepeatCounter
  {
    public string[] SpliteTheSentence(string sentence)
    {
      string[] newSentence = sentence.Split(' ');
      return newSentence;
    }
  }
}
