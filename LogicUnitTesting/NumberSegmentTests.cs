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
    public class NumberSegmentTests
    {
        NumberSegment segment;

        [TestMethod]
        public void Should_Correctly_Name_Single_Digit_Numbers()
        {
            segment = new NumberSegment("", 0);
            Assert.AreEqual("zero", segment.ValueAsText());

            segment = new NumberSegment("", 1);
            Assert.AreEqual("one", segment.ValueAsText());

            segment = new NumberSegment("", 2);
            Assert.AreEqual("two", segment.ValueAsText());

            segment = new NumberSegment("", 3);
            Assert.AreEqual("three", segment.ValueAsText());

            segment = new NumberSegment("", 4);
            Assert.AreEqual("four", segment.ValueAsText());

            segment = new NumberSegment("", 5);
            Assert.AreEqual("five", segment.ValueAsText());

            segment = new NumberSegment("", 6);
            Assert.AreEqual("six", segment.ValueAsText());

            segment = new NumberSegment("", 7);
            Assert.AreEqual("seven", segment.ValueAsText());

            segment = new NumberSegment("", 8);
            Assert.AreEqual("eight", segment.ValueAsText());

            segment = new NumberSegment("", 9);
            Assert.AreEqual("nine", segment.ValueAsText());

        }


        [TestMethod]
        public void Should_Correctly_Name_Teen_Digit_Numbers()
        {
            segment = new NumberSegment("", 10);
            Assert.AreEqual("ten", segment.ValueAsText());

            segment = new NumberSegment("", 11);
            Assert.AreEqual("eleven", segment.ValueAsText());

            segment = new NumberSegment("", 12);
            Assert.AreEqual("twelve", segment.ValueAsText());

            segment = new NumberSegment("", 13);
            Assert.AreEqual("thirteen", segment.ValueAsText());

            segment = new NumberSegment("", 14);
            Assert.AreEqual("fourteen", segment.ValueAsText());

            segment = new NumberSegment("", 15);
            Assert.AreEqual("fifteen", segment.ValueAsText());

            segment = new NumberSegment("", 16);
            Assert.AreEqual("sixteen", segment.ValueAsText());

            segment = new NumberSegment("", 17);
            Assert.AreEqual("seventeen", segment.ValueAsText());

            segment = new NumberSegment("", 18);
            Assert.AreEqual("eighteen", segment.ValueAsText());

            segment = new NumberSegment("", 19);
            Assert.AreEqual("nineteen", segment.ValueAsText());


        }


        [TestMethod]
        public void Should_Correctly_Name_Double_Digit_Numbers()
        {
            segment = new NumberSegment("", 20);
            Assert.AreEqual("twenty", segment.ValueAsText());

            segment = new NumberSegment("", 25);
            Assert.AreEqual("twenty five", segment.ValueAsText());

            segment = new NumberSegment("", 52);
            Assert.AreEqual("fifty two", segment.ValueAsText());

            segment = new NumberSegment("", 99);
            Assert.AreEqual("ninety nine", segment.ValueAsText());

            segment = new NumberSegment("", 67);
            Assert.AreEqual("sixty seven", segment.ValueAsText());
        }


        [TestMethod]
        public void Should_Correctly_Name_Three_Digit_Numbers()
        {
            segment = new NumberSegment("", 100);
            Assert.AreEqual("one hundred", segment.ValueAsText());

            segment = new NumberSegment("", 101);
            Assert.AreEqual("one hundred one", segment.ValueAsText());

            segment = new NumberSegment("", 120);
            Assert.AreEqual("one hundred twenty", segment.ValueAsText());

            segment = new NumberSegment("", 199);
            Assert.AreEqual("one hundred ninety nine", segment.ValueAsText());

            segment = new NumberSegment("", 275);
            Assert.AreEqual("two hundred seventy five", segment.ValueAsText());

            segment = new NumberSegment("", 511);
            Assert.AreEqual("five hundred eleven", segment.ValueAsText());

            segment = new NumberSegment("", 600);
            Assert.AreEqual("six hundred", segment.ValueAsText());

            segment = new NumberSegment("", 999);
            Assert.AreEqual("nine hundred ninety nine", segment.ValueAsText());
        }
    }
}
