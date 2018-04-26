using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLogic
{
    public class WholeNumberNamer
    {
        //Dictionary<string, int> _segments = new Dictionary<string, int>();
        List<NumberSegment> _segments = new List<NumberSegment>();
        private string[] _segmentNames = new string[] { "", "thousand", "million", "billion", "trillian", "quadrillion", "quintillion", "septillion", "octillion" };


        /// <summary>
        /// Loads a number to be parsed into segments
        /// </summary>
        /// <param name="number"></param>
        public WholeNumberNamer(decimal number)
        {
            Number = number;
            LoadSegments();
        }


        /// <summary>
        /// Splits the Number into named segments
        /// </summary>
        void LoadSegments()
        {
            string original = String.Format("{0:C}", Number).Replace("$", "");
            string left = original.Split('.')[0];
            string[] parts = left.Split(',');
            for (int i = 0; i < parts.Length; i++)
            {
                string segmentName = _segmentNames[parts.Length - 1 - i];
                int segmentValue = Convert.ToInt32(parts[i]);
                NumberSegment segment = new NumberSegment(segmentName, segmentValue);
                _segments.Add(segment);
            }
        }



        /// <summary>
        /// The Number passed in
        /// </summary>
        public decimal Number { get; private set; }


        /// <summary>
        /// The segments for the Number
        /// </summary>
        public List<NumberSegment> Segments { get { return _segments; } }


        /// <summary>
        /// Gets a number segment by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public NumberSegment GetSegmentByName(string name)
        {
            return Segments.Find(s => s.Name == name);
        }


        /// <summary>
        /// Gets the text representation of all segments (eg. Two thousand five hundred twenty-three)
        /// </summary>
        /// <returns></returns>
        public string GetWholeNumberName()
        {
            StringBuilder sb = new StringBuilder();
            foreach (NumberSegment segment in Segments)
                sb.AppendFormat("{0} {1} ", segment.ValueAsText(), segment.Name);

            return sb.ToString().Trim();
        }
    }
}
