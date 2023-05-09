using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalExam;

public class Task1
{

    public static bool CompareAnagrams(string anagram1, string anagram2)
    {
        Dictionary<char, int> keyValuePairs1= new Dictionary<char, int>();
        Dictionary<char, int> keyValuePairs2= new Dictionary<char, int>();

        CheckDictionary(keyValuePairs1, anagram1);
        CheckDictionary(keyValuePairs2, anagram2);

        if(keyValuePairs1.Count == keyValuePairs2.Count)
        {
            foreach(var keyValuePair in keyValuePairs1)
            {
                if(keyValuePairs2.TryGetValue(keyValuePair.Key, out int value) && value == keyValuePair.Value)
                {
                    Console.WriteLine($"Anagram 1 & 2 have the same number of characters of {keyValuePair.Key}");
                }
                else
                {
                    return false;
                }
            }
        }    
        else
            return false;

        return true;
    }

    public static void CheckDictionary(Dictionary<char, int> keyValues, string anagram)
    {
        foreach(char c in anagram)
        {
            if (keyValues.ContainsKey(c))
            {
                keyValues[c]++;
            }
            else
                keyValues.Add(c, 1);
        }
    }
}
