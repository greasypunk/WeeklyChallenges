using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var val in vals)
            {
                if (val == false) 
                    return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers != null)
            {
                int sum = 0;
                foreach (var num in numbers)
                {
                    if (Math.Abs(num % 2) == 1)
                        sum += num;                        
                }
                if (Math.Abs(sum % 2) == 1)
                    return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Length > 2 && password != password.ToUpper() && password != password.ToLower())
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if ("0123456789".Contains(password[i]))
                        return true;
                }
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return (divisor != 0) ? dividend / divisor : 0;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> oddsList = new List<int>();
            for (int i = 1; i < 100; i += 2)
                oddsList.Add(i);
            return oddsList.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i].ToString();
                string newWord = "";
                for (int j = 0; j < word.Length; j++)
                    newWord += word[j].ToString().ToUpper();
                words[i] = newWord;
            }
        }
    }
}
