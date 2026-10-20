using BaobabWildlifeRehab.Models;
using System.Collections.Generic;
using System.Linq;

namespace BaobabWildlifeRehab.BusinessLogic
{
    // Business layer - Feature: Summary
    internal partial class DataHandler
    {
        //Creates new SummaryReport and calls data.WriteSummary
        public SummaryReport GenerateSummary()
        {
            // Get the animals from the data layer
            List<Animal> animals = data.DataSource.Cast<Animal>().ToList();

            // Calculate the total number of animals
            int totalAnimals = animals.Count;

            // Calculate average age (null if there are no animals)
            double? averageAge = totalAnimals > 0? animals.Average(a => a.Age): (double?)null;

            // Calculate average recovery score (null if there are no animals)
            double? averageRecoveryScore = totalAnimals > 0? animals.Average(a => a.RecoveryScore): (double?)null;

            // Count the animals by status
            Dictionary<string, int> statusCounts = animals.GroupBy(a => a.Status).ToDictionary(g => g.Key, g => g.Count());

            // Create the SummaryReport object
            SummaryReport report = new SummaryReport(totalAnimals, averageAge, averageRecoveryScore, statusCounts);

            // Format the summary as text
            string summary =
                "Wildlife Rehabilitation Summary" + Environment.NewLine +
                "Generated: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + Environment.NewLine +
                "Total Animals: " + report.TotalAnimals + Environment.NewLine +
                "Average Age: " + FormatAverage(report.AverageAge) + Environment.NewLine +
                "Average Recovery Score: " + FormatAverage(report.AverageRecoveryScore) + Environment.NewLine +
                "Animals by Status:" + Environment.NewLine +
                string.Join(Environment.NewLine,
                    report.StatusCounts.Select(s => s.Key + ": " + s.Value));

            // Save the summary through the data layer
            data.WriteSummary(summary);

            // Return the report to the UI
            return report;
        }
        public string FormatAverage(double? average)
        {
            return average.HasValue
                ? average.Value.ToString("F2", System.Globalization.CultureInfo.InvariantCulture): "N/A";
        }
    }
}