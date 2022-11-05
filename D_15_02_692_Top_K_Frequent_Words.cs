using System;

public class D_15_02_692_Top_K_Frequent_Words
{
    public IList<string> TopKFrequent(string[] words, int k)
    {
        var counts = new Dictionary<string, int>();
        foreach (var word in words)
        {
            if (!counts.ContainsKey(word))
                counts[word] = 1;
            else
                counts[word]++;
        }

        var heap = new SortedDictionary<(string word, int count), int>(Comparer<(string word, int count)>.Create((a, b) =>
        {
            var result = a.count.CompareTo(b.count);
            if (result == 0)
                result = -a.word.CompareTo(b.word);
            return result;
        }));

        foreach (var word in counts.Keys)
        {
            heap[(word, counts[word])] = 1;
            if (heap.Count > k)
                heap.Remove(heap.Keys.First());
        }

        var results = new List<string>();
        foreach ((string word, int count) in heap.Keys)
            results.Add(word);

        results.Reverse();
        return results;
    }
}

/*
 692. Top K Frequent Words

Given an array of strings words and an integer k, return the k most frequent strings.

Return the answer sorted by the frequency from highest to lowest. Sort the words with the same frequency by their lexicographical order.

 

Example 1:

Input: words = ["i","love","leetcode","i","love","coding"], k = 2
Output: ["i","love"]
Explanation: "i" and "love" are the two most frequent words.
Note that "i" comes before "love" due to a lower alphabetical order.
Example 2:

Input: words = ["the","day","is","sunny","the","the","the","sunny","is","is"], k = 4
Output: ["the","is","sunny","day"]
Explanation: "the", "is", "sunny" and "day" are the four most frequent words, with the number of occurrence being 4, 3, 2 and 1 respectively.
*/