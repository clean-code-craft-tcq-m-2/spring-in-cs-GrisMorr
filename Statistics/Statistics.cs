using System;
using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        private Stats stats;
        public Double average;
        public Double max;
        public Double min;

        public Stats CalculateStatistics(List<float> numbers) {
            //Implement statistics here
            if (numbers.Count() == 0)
            {
                average = Double.NaN;
                max = Double.NaN;
                min = Double.NaN;
            }
            else { 
            average = numbers.Sum() / numbers.Count;
            max = numbers.Max();
            min = numbers.Min();
              }
            stats.setValues(average,max,min);
            return stats;
        }
    }
}
