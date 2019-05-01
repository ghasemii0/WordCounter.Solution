using System;

namespace WordCountModel
{
  public class RepeatCounter
  {
    private string _sentence;
    private string _word;
    private string[] _splitSentence;

    public RepeatCounter(string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
      _splitSentence = sentence.Split(" ");
    }

    public string[] GetSplitSentence()
    {
      return _splitSentence;
    }

    public int Count()
    {
      int count = 0;
      for (int i = 0; i < _splitSentence.Length; i++)
      {
        if(_splitSentence[i] == _word)
        count ++;
      }
      return count;
    }
  }
}
