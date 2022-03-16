using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class GIBDD
    {
        private static string _currentNumber = "A001AA";

        private static List<string> numbers = new List<string> { "А", "В", "Е", "К", "М", "Н", "О", "Р", "С", "Т", "У", "Х" };
        private static string NumberGenerate(string? currentNumber = null)
        {
            if (currentNumber == null) return "А001АА";
            var chars = currentNumber.Reverse().ToList();
            for (var i = 0; i < chars.Count(); i++)
            {
                if (char.IsDigit(chars[i]))
                {
                    if (chars[i] == '9')
                    {
                        chars[i] = '0';
                        continue;
                    }
                    else
                    {
                        chars[i] = (Convert.ToInt32(chars[i].ToString()) + 1).ToString().First();
                        chars.Reverse();
                        return String.Join(String.Empty, chars);
                    }
                }
                else
                {
                    var index = numbers.IndexOf(chars[i].ToString());
                    if (chars[i].ToString() == numbers.Last())
                    {
                        chars[i] = numbers.First().First();
                        continue;
                    }
                    else
                    {
                        chars[i] = numbers[numbers.IndexOf(chars[i].ToString()) + 1].First();
                        chars.Reverse();
                        return String.Join(String.Empty, chars);
                    }
                }
            }
            return "Х999ХХ";
        }

        public static string GenerateNumberCar()
        {
            var number = NumberGenerate(_currentNumber);
            _currentNumber = number;
            
            return number;
        }
    }
}
