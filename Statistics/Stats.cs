using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{    public struct Stats
    {
        public Double average { get; set; }
        public Double max { get; set; }
        public Double min { get; set; }
        public void setValues(Double average, Double max, Double min)
        {
            this.average = average;
            this.max = max;
            this.min = min;
        }
    }
}
