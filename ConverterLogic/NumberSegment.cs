using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLogic
{
    public class NumberSegment
    {
        string[] _lessThanTwenty = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] _tens = new string[] { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        public NumberSegment(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; private set; }

        public int Value { get; private set; }

        public string ValueAsText()
        {
            if (Value < 20)
                return _lessThanTwenty[Value];

            // get hundreds
            string padded = Value.ToString().PadLeft(3, '0');
            int h = Convert.ToInt32(padded.Substring(0, 1));
            string hundreds = "";
            if (h > 0)
                hundreds = string.Format("{0} hundred", _lessThanTwenty[h]);

            // get the value of the tens place
            int tens = Value - 100 * h;

            // get the tens value
            string tensValue = "";
            string singlesValue = "";
            if (tens < 20)
            {
                tensValue = _lessThanTwenty[tens];
            }
            else
            {
                int tensIndex = (int)((tens) / 10) - 2;
                tensValue = _tens[tensIndex];

                int singlesIndex = (Value % 10);
                singlesValue = _lessThanTwenty[singlesIndex];
            }

            // put it all together
            return string.Format("{0} {1} {2}", hundreds, tensValue, singlesValue).Replace("zero", "").Trim();

        }
    }
}
