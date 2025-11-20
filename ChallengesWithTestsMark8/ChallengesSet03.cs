using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        string alphabetLower = "abcdefghijklmnopqrstuvwxyz";
        string alphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string numbers = "0123456789";

        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool result = false;

            for (int counter = 0; counter < vals.Length; counter++)
            {
                if (vals[counter] == false)
                {
                    result = true;
                }
            }

            return result;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {

            if (numbers == null)
            {
                return false;
            }
            
            int total = 0;
            foreach (int number in numbers)
            {
                if (number % 2 != 0)
                {
                    total += number;
                }
            }

            if (total % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool containsUpper = false;
            bool containsLower = false;
            bool containsNumber = false;
            bool containsAll = false;

            foreach (char character in password)
            {
                for (int upperCounter = 0; upperCounter < alphabetUpper.Length && containsUpper == false; upperCounter++)
                {
                    if (character == alphabetUpper[upperCounter])
                    {
                        containsUpper = true;
                    }
                }

                for (int lowerCounter = 0; lowerCounter < alphabetLower.Length && containsLower == false; lowerCounter++)
                {
                    if (character == alphabetLower[lowerCounter])
                    {
                        containsLower = true;
                    }
                }

                for (int numberCounter = 0; numberCounter < numbers.Length && containsNumber == false; numberCounter++)
                {
                    if (character == numbers[numberCounter])
                    {
                        containsNumber = true;
                    }
                }
            }

            if (containsUpper == true && containsLower == true && containsNumber == true)
            {
                containsAll = true;
            }
            
            return containsAll;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            int lastIndex = val.Length - 1;
            return val[lastIndex];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            decimal result;
            if (divisor == 0)
            {
                result = 0;
            }
            else
            {
                result = dividend / divisor;
            }
            return result;
        }

        public int LastMinusFirst(int[] nums)
        {
            int firstNumber = nums[0];
            int lastNumber = nums[nums.Length - 1];
            
            int result = lastNumber - firstNumber;
            return result;
        }

        public int[] GetOddsBelow100()
        {
            List<int> oddNumbers = new List<int>();

            for (int counter = 0; counter < 100; counter++)
            {
                if (counter % 2 != 0)
                {
                    oddNumbers.Add(counter);
                }
            }

            return oddNumbers.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int index = 0; index < words.Length; index++)
            {
                words[index] = words[index].ToUpper();
            }
        }
    }
}
            
        
    

