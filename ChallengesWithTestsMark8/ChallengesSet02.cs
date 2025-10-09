using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {

            string alphabetLower = "abcdefghijklmnopqrstuvwxyz";
            string alphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            foreach (char letter in alphabetLower)
            {
                if (letter == c)
                {
                    return true;
                }
            }

            foreach (char letter in alphabetUpper)
            {
                if (char.ToUpper(c) == letter)
                {
                    return true;
                }
            }

            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else if (num == 0)
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {

            double total = 0;
            int counter = 0;
            double lowestNumber = 0;
            double highestNumber = 0;
            
            if (numbers == null)
            {
                return 0;
            }

            int numberOfItems = 0;
            
            foreach (double number in numbers)
            {
                numberOfItems++;
            }
            
            double[] itemList = new double[numberOfItems];

            foreach (double number in numbers)
            {
                
                itemList[counter] = number;
                counter++;
            }

            if (itemList.Length == 1)
            {
                total = itemList[0] + itemList[0];
                return total;
            }

            for (int counterTwo = 0; counterTwo < itemList.Length; counterTwo++)
            {
                if (counterTwo == 0)
                {
                    lowestNumber = itemList[0];
                    highestNumber = itemList[0];
                }

                if (itemList[counterTwo] < lowestNumber)
                {
                    lowestNumber = itemList[counterTwo];
                }

                if (itemList[counterTwo] > highestNumber)
                {
                    highestNumber = itemList[counterTwo];
                }
            }
            
            total =  lowestNumber + highestNumber;
            

            

            return total;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else if (str2.Length < str1.Length)
            {
                return str2.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        public int SumEvens(int[] numbers)
        {

            if (numbers == null)
            {
                return 0;
            }
            
            int total = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    total += number;
                }
            }
            
            return total;
        }

        public bool IsSumOdd(List<int> numbers)
        {

            if (numbers == null)
            {
                return false;
            }
            
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            if (sum % 2 != 0)
            {
                return true;
            }
            else if (sum == 0)
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long validNumbers = 0;
            long startingNumber = number - 1;
            while (startingNumber > 0)
            {
                if (startingNumber % 2 != 0 && startingNumber != 0)
                {
                    validNumbers++;
                }
                startingNumber--;
            }
            return validNumbers;
        }
    }
}
