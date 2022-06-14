using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words != null)
            {
                foreach (string entry in words)
                {
                    if (entry != null
                        && (ignoreCase && (entry.ToLower() == word.ToLower()))
                        || (!ignoreCase && (entry == word)))
                        return true;
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num >= 2) 
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                        return false;
                }
                return true;
            }
            return false;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            string toCheck;
            string checks = "";
            for (int i = (str.Length - 1); i >= 0; i--)
            {
                if (!checks.Contains(str[i]))
                {
                    checks += str[i];
                    toCheck = str[..i];
                    if (!toCheck.Contains(str[i]))
                        return i;
                }
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int curCount = 1;
            int maxCount = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                curCount = (numbers[i] == numbers[i - 1]) ? curCount + 1 : 1;
                maxCount = Math.Max(curCount, maxCount);
            }
            return maxCount;        
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> everyNth = new List<double>();
            if (elements == null || n < 0 || n > elements.Count)
                return new double[0];
            else if (elements != null)
            {
                if (0 < n && n <= elements.Count)
                {
                    for (int i = n - 1; i < elements.Count; i += n)
                        everyNth.Add(elements[i]);
                }
            }
            return everyNth.ToArray();
        }
    }
}
