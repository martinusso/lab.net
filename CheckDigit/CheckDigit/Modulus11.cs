using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckDigit
{
    public class Modulus11
    {
        public string CalculateCheckDigit(string number)
        {
            int sum = GetDigitSum(number);

            int mod = (sum % 11);

            if (mod == 0 || mod == 1) return "0";
            return (11 - mod).ToString();
        }

        private int GetDigitSum(string number)
        {
            int sum = 0;
            for (int i = number.Length - 1, multiplier = 2; i >= 0; i--)
            {
                sum += (int)char.GetNumericValue(number[i]) * multiplier;
                if (++multiplier > 9) multiplier = 2;
            }
            return sum;
        }
    }
}
