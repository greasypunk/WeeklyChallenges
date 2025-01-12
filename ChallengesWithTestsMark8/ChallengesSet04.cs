﻿using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
                sum += (numbers[i] % 2 == 0) ? numbers[i] : numbers[i] * (-1);
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return Math.Min(Math.Min(str1.Length, str2.Length), Math.Min(str3.Length, str4.Length));
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(number1, number2), Math.Min(number3, number4));
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (((sideLength1 + sideLength2) > sideLength3) && ((sideLength1 + sideLength3) > sideLength2) && ((sideLength2 + sideLength3) > sideLength1)) ? true : false;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double whocares);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            double numNull = 0;
            if (objs.Length > 0)
            {
                foreach (var obj in objs)
                    numNull += (obj == null) ? 1 : 0;
                return (numNull / objs.Length > 0.5) ? true : false;
            }
            else
                return true;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers != null && numbers.Length > 0) 
            {
                double sumEvens = 0;
                double countEvens = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0) {
                        sumEvens += numbers[i];
                        countEvens += 1; }
                }
                return (countEvens > 0) ? sumEvens / countEvens : 0 ;
            }
            return 0;
        }

        public int Factorial(int number)
        {
            if (number >= 0)
            {
                int fact = 1;
                for (int i = number; i > 1; i--)
                    fact *= i;
                return fact;
            }
            else if (number < 0)
                throw new ArgumentOutOfRangeException();
            return 0;
        }
    }
}
