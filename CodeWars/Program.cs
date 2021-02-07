using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string AlphabetPosition(string text)
            {
                Console.WriteLine(text);
                Console.WriteLine();
                string buff = "";
                string lowerLetters = @"abcdefghijklmnopqrstuvwxyz";
                string upperLetters = @"ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                for (int num = 0; num < text.Length; num++)
                {
                    int index = 0;
                    for (int i = 0; i < lowerLetters.Length; i++)
                    {
                        if (text[num] == lowerLetters[i])
                        {

                            index = lowerLetters.IndexOf(lowerLetters[i]);
                            buff = buff.Insert(buff.Length, (index + 1) + " ");
                            break;

                        }

                    }
                    for (int n = 0; n < upperLetters.Length; n++)
                    {
                        if (text[num] == upperLetters[n])
                        {

                            index = upperLetters.IndexOf(upperLetters[n]);
                            buff = buff.Insert(buff.Length, (index + 1) + " ");
                            break;
                        }
                    }
                }
                if (buff.Length != 0)
                {
                    buff = buff.Remove(buff.Length - 1);
                }
                text = buff;

                Console.WriteLine(text);
                return text;
            }
            double basicOp(char operation, double value1, double value2)
            {
                double result = 0;
                switch (operation)
                {
                    case '+':
                        result = value1 + value2;
                        break;
                }
                switch (operation)
                {
                    case '-':
                        result = value1 - value2;
                        break;

                }
                switch (operation)
                {
                    case '*':
                        result = value1 * value2;
                        break;

                }
                switch (operation)
                {
                    case '/':
                        result = value1 / value2;
                        break;

                }
                return result;
            }
            int DescendingOrder(int num)
            {
                string result = null;
                string str = num.ToString();
                int[] nums = new int[str.Length];

                for (int i = 0; i < str.Length; i++)
                {
                    nums[i] = int.Parse(str[i].ToString());
                }

                Array.Sort(nums);
                Array.Reverse(nums);

                foreach (int number in nums)
                {
                    result += number.ToString();
                }

                return int.Parse(result);
            }
            int[] SortArray(int[] array)
            {
                int arrLenght = 0;   //find odd numbers array lenght
                foreach (int num in array)
                {
                    if (num % 2 != 0)
                    {
                        arrLenght++;
                    }
                }
                int[] odd = new int[arrLenght]; //create odd numbers array
                int count = 0;
                for (int i = 0; i < array.Length; i++) //add odd numbers to array
                {
                    if (array[i] % 2 != 0)
                    {
                        odd[count] = array[i];
                        count++;
                    }
                }
                Array.Sort(odd); //sort odd numbers
                count = 0;
                for (int i = 0; i < array.Length; i++) //fill array by sorted odd numbers
                {
                    if (array[i] % 2 != 0)
                    {
                        array[i] = odd[count];
                        count++;
                    }
                }
                return array;
            }
            bool IsPangram(string str)
            {
                string letters = "abcdefghijklmnopqrstuvwxyz";
                int lettersCount = 0;
                str = str.ToLower();
                for (int i = 0; i < letters.Length; i++)
                {
                    if (str.Contains(letters[i]))
                    {
                        lettersCount++;
                    }
                }

                if (lettersCount == letters.Length)
                {
                    return true;
                }
                else { return false; }
            }
            string LongestConsec(string[] strarr, int k)
            {
                string resultString = "";

                int maxLetters = 0;

                for (int i = 0; i < strarr.Length - k + 1; i++)
                {
                    string maxLettersString = "";

                    for (int u = 0; u < k; u++)
                    {
                        maxLettersString += strarr[i + u];
                    }
                    if (maxLetters < maxLettersString.Length)
                    {
                        maxLetters = maxLettersString.Length;
                        resultString = maxLettersString;
                    }
                }

                if (resultString == null) { return ""; }
                return resultString;
            }
        }
    }
}
