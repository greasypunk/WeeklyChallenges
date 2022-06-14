using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {

        public bool CharacterIsALetter(char c)
        {
            string abc = "abcdefghijklmnopqrstuvwxyz";
            return abc.Contains(c) || abc.ToUpper().Contains(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0) ? true: false;
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0) ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0) ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
                return 0;
            double? min = null;
            double? max = null;
            foreach (double num in numbers)
            {
                if (num > max || (max == null))
                    max = num;
                if (num < min || (min == null))
                    min = num;
            }
            return (min != null && max != null) ? (double)(max + min) : 0;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return Math.Min(str1.Length, str2.Length);
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers != null)
            {
                foreach (int num in numbers)
                    sum += num;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int evenSum = 0;
            if (numbers != null)
            {
                foreach (var num in numbers)
                    if (num % 2 == 0)
                        evenSum += num;
            }       
            return evenSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return (numbers != null) ? Math.Abs(Sum(numbers.ToArray()) % 2) == 1 : false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return (number > 0) ? number / 2 : 0;
        }
    }
}
