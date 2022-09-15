using Statistics.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{
    public class StatsAlerter
    {
        float maxThreshold;
        IAlerter[] alerters;
        public StatsAlerter(float maxThreshold,IAlerter[] alerters)
        {
            this.maxThreshold = maxThreshold;
            this.alerters = alerters;
        

        }

        public void checkAndAlert(List<float> list)
        {
            StatsComputer stats = new StatsComputer();

            if (this.maxThreshold > stats.CalculateStatistics(list).max)
            {
               EmailAlert emailAlert = this.alerters[0] as EmailAlert;
               LEDAlert ledAlert = this.alerters[1] as LEDAlert;
                emailAlert.emailSent = true;
                ledAlert.ledGlows = true;

            }
        }
    }
}
