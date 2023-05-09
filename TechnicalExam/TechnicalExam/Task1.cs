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

        foreach(char c in anagram1)
        {
            if(keyValuePairs1.ContainsKey(c))
            {
                keyValuePairs1[c]++;
            }
            else
                keyValuePairs1.Add(c, 1);
        }

        foreach (char c in anagram2)
        {
            if (keyValuePairs2.ContainsKey(c))
            {
                keyValuePairs2[c]++;
            }
            else
                keyValuePairs2.Add(c, 1);
        }

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

}
