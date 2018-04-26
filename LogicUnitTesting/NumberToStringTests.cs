using ConverterLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicUnitTesting
{
    [TestClass]

    public class NumberToStringTests
    {

        NumberToString converter;


        [TestMethod]
        public void Should_Return_Decimal_Portion_Of_Number_As_A_Long_Form_String()
        {
            converter = new NumberToString(17.05M);
            Assert.AreEqual("05/100", converter.GetDecimalPortionString());

            converter = new NumberToString(17M);
            Assert.AreEqual("00/100", converter.GetDecimalPortionString());

            converter = new NumberToString(17.99M);
            Assert.AreEqual("99/100", converter.GetDecimalPortionString());
        }


        [TestMethod]
        public void Should_Round_The_Decimal_Portion_To_Two_Decimal_Places()
        {
            converter = new NumberToString(17.009M);
            Assert.AreEqual("01/100", converter.GetDecimalPortionString());

            converter = new NumberToString(17.00001M);
            Assert.AreEqual("00/100", converter.GetDecimalPortionString());
        }


        [TestMethod]
        public void Should_Correctly_Assemble_Whole_And_Decimal_Portions_Of_Number()
        {
            converter = new NumberToString(17.01M);
            Assert.AreEqual("seventeen and 01/100", converter.GetNumberText());

            converter = new NumberToString(1721);
            Assert.AreEqual("one thousand seven hundred twenty one and 00/100", converter.GetNumberText());

            // 35,242,341,721
            converter = new NumberToString(35242341721.42M);
            Assert.AreEqual("thirty five billion two hundred fourty two million three hundred fourty one thousand seven hundred twenty one and 42/100", converter.GetNumberText());

        }





    }
}
