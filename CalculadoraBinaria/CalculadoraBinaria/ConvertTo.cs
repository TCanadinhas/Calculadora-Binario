using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraBinaria
{
    class ConvertTo
    {
        public static string Reverse(string digitated)
        {
            int size = digitated.Length;
            char[] digits = new char[size];

            for (int i = 0; i < size; i++)
            {
                digits[i] = digitated[size - 1 - i];
            }

            return new string(digits);
        }
        
        public static int ToDecimal(string willConvert)
        {
            int index = 0, result = 0, binary;

            string reverted = Reverse(willConvert);

            for (int i = 0; i < reverted.Length; i++)
            {
                binary = Convert.ToInt32(reverted.Substring(i, 1));
                result += binary * (int)Math.Pow(2, index);
                index++;
            }

            return result;

        }

        public static string ToBinary(string number)
        {

            string result = "";

            int dividend = Convert.ToInt32(number);

            if (dividend == 0 || dividend == 1)
            {
                return Convert.ToString(dividend);
            }

            else
            {
                while (dividend > 0)
                {
                    result += Convert.ToString(dividend % 2);

                    dividend = dividend / 2;
                }

                return Reverse(result);
            }
        }
    }
}
