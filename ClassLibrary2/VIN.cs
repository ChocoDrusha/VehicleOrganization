using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class VIN
    {
        public static bool Validate(string number)
        {
            bool flag = true;
            int len = number.Length;
            if (len != 17)
            {
                flag = false;
            }
            string CharsStr = "0123456789ABCDEFGHJKLMNPRSTUVWXYZ";
            foreach (var ch in number)
            {
                if (!CharsStr.Contains(ch.ToString()))
                {
                    flag = false;
                    break;
                }
            }
            for (int i = 13; i < len; i++)
            {
                try
                {
                    Convert.ToInt32(CharsStr[i]);
                }
                catch
                {
                    flag = false;
                    break;
                }

            }
            return flag;
        }

        public static bool ControlValidate(string number)
        {
            Dictionary<char, int> Values = new Dictionary<char, int>()
                {                          //0123456789ABCDEFGHJKLMNPRSTUVWXYZ
                    {'0',0},{'1',1},{'2',2},{'3',3},{'4',4},{'5',5},{'6',6},{'7',7},{'8',8},{'9',9},
                    {'A',1},{'B',2},{'C',3},{'D',4},{'E',5},{'F',6},{'G',7},{'H',8},{'J',1},{'K',2},
                    {'L',3},{'M',4},{'N',5},{'P',7},{'R',9},{'S',2},{'T',3},{'U',4},{'V',5},{'W',6},
                    {'X',7},{'Y',8},{'Z',9}

                };

            int[] Multipy = new int[] { 8, 7, 6, 5, 4, 3, 2, 10, 0, 9, 8, 7, 6, 5, 4, 3, 2 };

            int sum = 0;

            for (int i = 0; i < Multipy.Length; i++)
            {
                char a = number[i];
                sum += Values[number[i]] * Multipy[i];

            }

            if (number[8] == 'X')
            {
                if (sum % 11 == 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                int control = sum % 11;
                if (control == number[8])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
