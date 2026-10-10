using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaobabWildlifeRehab.Models
{
    internal class SummaryReport
    {
        public SummaryReport(int totalAnimals, double? averageAge, double? averageRecoveryScore, Dictionary<string, int> statusCounts)
        {
            TotalAnimals = totalAnimals;
            AverageAge = averageAge;
            AverageRecoveryScore = averageRecoveryScore;
            StatusCounts = statusCounts;
        }

        public int TotalAnimals { get; set; }
        public double? AverageAge { get; set; } // null = no animals -> show "N/A"
        public double? AverageRecoveryScore { get; set; } // null = no animals -> show "N/A"
        public Dictionary<string, int> StatusCounts { get; set; }
    }
}
