namespace EarliestCharacterInWords
{
    public class SortEarliestCharacterInWords
    {
        public static string[] SortWords(string[] words)
        {
            var sortedWords = words.OrderBy(x => x.Where(c => Char.IsLetter(c)).Min()).ToArray();

            // words.OrderBy(x => x.Where(c => Char.IsLetter(c)).Min()).ToArray() is a LINQ expression in C#
            // It sorts a list of strings (words) based on the earliest alphabetic character in each word.
            // It works by first applying the OrderBy method to the list words.
            // The OrderBy method takes a lambda expression as a parameter that specifies the sorting key
            // The lambda expression in this case is x => x.Where(c => Char.IsLetter(c)).Min().

            // x represents each string in the list words.
            // x.Where(c => Char.IsLetter(c)) filters out non-letter characters from the string x and returns a sequence of letters.
            // Min() method returns the minimum value in the sequence of letters, which is the earliest alphabetic character in the word x.
            // So, x.Where(c => Char.IsLetter(c)).Min() returns the earliest alphabetic character in the word x.

            // Finally, the ToArray method is applied to the result to convert it back to an array.

            // The sorting is done in ascending order based on the earliest alphabetic character in each word, and the resulting sorted array is returned.


            return sortedWords;

            // We return te sorted words to the calling code.
        }
    }
}