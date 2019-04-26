namespace WordCountModel
{
  public class RepeatCounter
  {
    private string _Sentence;
    public string[] SpliteTheSentence(string sentence)
    {
      _Sentence = sentence;
      string[] newSentence = _Sentence.Split(' ');
      return newSentence;
    }

    public int Count(string word)
    {
      string[] newSentence = SpliteTheSentence(_Sentence);
      int count = 0;
      for (int i = 0; i < newSentence.Length; i++)
      {
        if(newSentence[i] == word)
        count++;
      }
      return count;
    }
  }
}
