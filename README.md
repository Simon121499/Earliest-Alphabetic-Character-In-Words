# Earliest-Alphabetic-Character-In-Words
Given a list of strings, this program sorts the list based on the earliest alphabetic character in each word.

To build the project cd to "Earliest-Alphabetic-Character-In-Words\EarliestCharacterInWords" and run "dotnet build"

To run the test case cd to "Earliest-Alphabetic-Character-In-Words\EarliestCharacterInWordsTests" and run "dotnet test" 

In "Earliest-Alphabetic-Character-In-Words\EarliestCharacterInWords\SortEarliestCharacterInWords.cs", the method used to find earliest alphabetic character in each word is "SortWords" and this accepts a string array. LINQ is used in the method implementation as this reduces the amount of code written by making it more readable.

In the method this "words.OrderBy(x => x.Where(c => Char.IsLetter(c)).Min()).ToArray()" was used and it is a LINQ expression in C# that sorts a list of strings (words) based on the earliest alphabetic character in each word.

The above works by first applying the OrderBy method to the list words. The OrderBy method takes a lambda expression as a parameter that specifies the sorting key. The lambda expression in this case is x => x.Where(c => Char.IsLetter(c)).Min().

This is how it works:

x represents each string in the list words.
x.Where(c => Char.IsLetter(c)) filters out non-letter characters from the string x and returns a sequence of letters.
Min() method returns the minimum value in the sequence of letters, which is the earliest alphabetic character in the word x.
So, x.Where(c => Char.IsLetter(c)).Min() returns the earliest alphabetic character in the word x.

Finally, the ToArray method is applied to the result to convert it back to an array. The sorting is done in ascending order based on the earliest alphabetic character in each word, and the resulting sorted array is returned.
