
using EarliestCharacterInWords;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace EarliestCharacterInWordsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SortEarliestWordsInTest()
        {

            // Arrange
            // Words to sort and test with
            string[] words = { "dog", "fox", "snake" };

            // Act
            // Sorted words
            string[] sortedWords = SortEarliestCharacterInWords.SortWords(words);

            // Assert
            // Assert that the sorted words returned from our implemented method is the same as expected words
            CollectionAssert.AreEqual(new List<string> { "snake", "dog", "fox" }, sortedWords);
        }
    }
}