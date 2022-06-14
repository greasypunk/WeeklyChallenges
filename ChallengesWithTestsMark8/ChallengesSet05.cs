using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return (startNumber + n) - (startNumber % n);
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                    businesses[i].Name = "CLOSED";
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers != null && numbers.Length > 0)
            {
                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] < numbers[i - 1])
                        return false;
                }
                return true;
            }
            return false;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if (numbers != null) {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] % 2 == 0)
                        sum += numbers[i + 1];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string sentence = "";
            if (words != null && words.Length > 0)
            {
                foreach (var word in words)
                    sentence = (word.Trim().Length > 0) ? sentence + word.Trim() + " " : sentence;
                if (sentence.Trim().Length > 0)
                    sentence = sentence.TrimEnd() + ".";
            }
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> everyFourth = new List<double>();
            if (elements != null && elements.Count > 3)
            {
                for (int i = 3; i < elements.Count; i += 4)
                    everyFourth.Add(elements[i]);
            }
            return everyFourth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                        return true;
                }
            }
            return false;

        }
    }
}
