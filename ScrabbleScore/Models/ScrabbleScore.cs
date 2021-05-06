using System;
using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class ScrabbleWord
  {
    public string Word { get; set; }
    public int Value { get; set; }
    private static List<ScrabbleWord> _instances = new List<ScrabbleWord> { };
    public static List<ScrabbleWord> GetAll()
    {
      return _instances;
    }
    public ScrabbleWord(string word)
    {
      Word = word;
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public ScrabbleWord(string word, int value)
      : this(word)
    {
      Value = value;
    }
  }

}
