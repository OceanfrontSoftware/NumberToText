using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLogic
{
    public class NumberToString
    {

        /// <summary>
        /// Create a new instance of the number to s
        /// </summary>
        /// <param name="number"></param>
        public NumberToString(decimal number)
        {
            Number = number;
        }


        /// <summary>
        /// The number being converted
        /// </summary>
        public decimal Number { get; private set; }


        /// <summary>
        /// Returns the decimal portion of the Number as a written out number
        /// </summary>
        /// <returns></returns>
        public string GetDecimalPortionString()
        {
            string original = String.Format("{0:C}", Number);
            string right = original.Split('.')[1];
            return string.Format("{0}/100", right);
        }


        /// <summary>
        /// Returns the whole number portion of the Number as a written out number
        /// </summary>
        /// <returns></returns>
        public string GetWholeNumberPortionString()
        {
            WholeNumberNamer namer = new WholeNumberNamer(Number);
            return namer.GetWholeNumberName();
        }


        /// <summary>
        /// Gets the Number represented as text
        /// </summary>
        /// <returns></returns>
        public string GetNumberText()
        {
            WholeNumberNamer namer = new WholeNumberNamer(Number);
            string wholeNumber = namer.GetWholeNumberName();
            string decimalNumber = GetDecimalPortionString();
            return string.Format("{0} and {1}", wholeNumber, decimalNumber);
        }








    }
}
