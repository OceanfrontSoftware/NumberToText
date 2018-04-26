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
    public class WholeNumberNamerTests
    {
        WholeNumberNamer namer;

        [TestMethod]
        public void Should_Correctly_Label_Whole_Number_Segments()
        {
            //10,253,687,218,378,112
            namer = new WholeNumberNamer(10253687218378112M);
            Assert.AreEqual(6, namer.Segments.Count);
            Assert.AreEqual(10, namer.GetSegmentByName("quadrillion").Value);
            Assert.AreEqual(253, namer.GetSegmentByName("trillian").Value);
            Assert.AreEqual(687, namer.GetSegmentByName("billion").Value);
            Assert.AreEqual(218, namer.GetSegmentByName("million").Value);
            Assert.AreEqual(378, namer.GetSegmentByName("thousand").Value);
            Assert.AreEqual(112, namer.GetSegmentByName("").Value);
        }

        [TestMethod]
        public void Should_Correctly_Name_Any_Whole_Number()
        {

            namer = new WholeNumberNamer(0);
            Assert.AreEqual("zero", namer.GetWholeNumberName());

            namer = new WholeNumberNamer(9);
            Assert.AreEqual("nine", namer.GetWholeNumberName());

            namer = new WholeNumberNamer(11);
            Assert.AreEqual("eleven", namer.GetWholeNumberName());

            namer = new WholeNumberNamer(20);
            Assert.AreEqual("twenty", namer.GetWholeNumberName());

            namer = new WholeNumberNamer(253);
            Assert.AreEqual("two hundred fifty three", namer.GetWholeNumberName());

            namer = new WholeNumberNamer(2523);
            Assert.AreEqual("two thousand five hundred twenty three", namer.GetWholeNumberName());

            // 22,687,926
            namer = new WholeNumberNamer(22687926);
            Assert.AreEqual("twenty two million six hundred eighty seven thousand nine hundred twenty six", namer.GetWholeNumberName());


        }

    }
}
