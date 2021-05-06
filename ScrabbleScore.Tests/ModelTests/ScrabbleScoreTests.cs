using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;
using System.Collections.Generic;
using System;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleWordTests : IDisposable
  {
    public void Dispose()
    {
      ScrabbleWord.ClearAll();
    }
    [TestMethod]
    public void ScrabbleScoreConstructor_CreatesInstanceOfScrabbleScore_Item()
    {
      ScrabbleWord newScore = new ScrabbleWord("word");
      Assert.AreEqual(typeof(ScrabbleWord), newScore.GetType());
    }
    [TestMethod]
    public void GetWord_ReturnWord_String()
    {
      string word = "gravy";
      ScrabbleWord newScrabbleWord = new ScrabbleWord(word);
      string result = newScrabbleWord.Word;
      Assert.AreEqual(word, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      List<ScrabbleWord> newList = new List<ScrabbleWord> { };
      List<ScrabbleWord> result = ScrabbleWord.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }


  }
}

