using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalChallenge.Models
{
    public class Fixture
    {
        public int ID { get; set; }
        public string Venue { get; set; }
        public DateTime MatchDate { get; set; }
        public double CourtFees { get; set; }
    }
}
