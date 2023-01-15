using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.WPF.db
{
    public class ChAssessment
    {
        public int ChAssessmentId { get; set; }
        public DateTime TimeStamp { get; set; }
        public int WPM { get; set; }
        public int CharCorrectness { get; set; }
        public int StrokeCount { get; set; }
        public int StrokeOrder { get; set; }
        public int BaseLine { get; set; }
        public int SizeConsistency { get; set; }
        public int Smoothness { get; set; }
    }
}
