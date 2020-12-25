using System;
using System.Collections.Generic;

namespace _07._Word_Cruncher
{
    class Program
    {
        private static string[] words;
        private static string target;
        private static List<string> selectedWords;
        private static string currentWord;
        private static Dictionary<int, List<string>> wordsByLen;
        private static Dictionary<string, int> occurances;
        private static HashSet<string> results;
        static void Main(string[] args)
        {
            words = Console.ReadLine().Split(", ");
            target = Console.ReadLine();
            wordsByLen = new Dictionary<int, List<string>>();
            selectedWords = new List<string>();
            occurances = new Dictionary<string, int>();
            foreach (var word in words)
            {
                var len = word.Length;
                if (!wordsByLen.ContainsKey(len))
                {
                    wordsByLen.Add(len, new List<string>());
                }
                wordsByLen[len].Add(word);
                if (occurances.ContainsKey(word))
                {
                    occurances[word] += 1;
                }
                else
                {
                    occurances.Add(word, 1);
                }
            }
            results = new HashSet<string>();
            GenSolutions(target.Length);
            Console.WriteLine(string.Join(Environment.NewLine, results));
        }
        private static void GenSolutions(int remainingLen)
        {
            if (remainingLen == 0)
            {
                if (currentWord == target)
                {
                    results.Add(string.Join(" ", selectedWords));
                }
                return;
            }
            foreach (var kvp in wordsByLen)
            {
                if (kvp.Key > remainingLen)
                {
                    continue;
                }
                foreach (var word in kvp.Value)
                {
                    if (occurances[word] > 0)
                    {
                        currentWord += word;
                        if (IsPartialMatching(target, currentWord))
                        {
                            occurances[word] -= 1;
                            selectedWords.Add(word);
                            GenSolutions(remainingLen - kvp.Key);
                            selectedWords.RemoveAt(selectedWords.Count - 1);
                            occurances[word] += 1;
                        }
                        currentWord = currentWord.Remove(currentWord.Length - word.Length, word.Length);
                    }
                }
            }
        }

        private static bool IsPartialMatching(string expected, string actual)
        {
            for (int i = 0; i < actual.Length; i++)
            {
                if (expected[i] != actual[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

