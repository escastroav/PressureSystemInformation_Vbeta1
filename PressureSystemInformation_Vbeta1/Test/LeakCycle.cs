using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressureSystemInformation_Vbeta1.Test
{    
    public class LeakCycle
    {
        private readonly uint cycleID;
        public uint CycleID { get { return cycleID; } }

        private readonly DateTime startDate;
        public DateTime StartDate{ get{ return startDate; } }

        private double cycleTime;
        public double CycleTime { get { return cycleTime; } set { cycleTime = value; } }

        private double pressurePeak;
        public double PressurePeak { get { return pressurePeak; } set { pressurePeak = value; } }

        private double pressureDrop;
        public double PressureDrop { get { return pressureDrop; } set { pressureDrop = value; } }

        private bool pass;
        public bool Pass { get{ return pass; } set{ pass = value; } }

        private readonly double startTime;
        private double initialPeakPressure;

        public LeakCycle(uint id, double startTime, double initialPeakPressure, DateTime startDate)
        {
            this.cycleID = id;
            this.startTime = startTime;
            this.initialPeakPressure = initialPeakPressure;
            pressurePeak = initialPeakPressure;
            this.startDate = startDate;
        }

        public void UpdateCycle(double currentTime, double currentPressure) 
        {
            UpdatePeak(currentPressure);
            UpdateDrop(currentPressure);
            UpdateCycleTime(currentTime);
        }
        public void EndCycle(double ExpectedDrop, string type) 
        {
            if (type == "%")
                EvaluateCycleByPercent(ExpectedDrop);
            else if (type == "PSI")
                EvaluateCycleByValue(ExpectedDrop);
            else
                EvaluateCycleByPercent(ExpectedDrop);
        }
        
        private void UpdatePeak(double currentPressure) 
        {
            if (currentPressure > pressurePeak && currentPressure > initialPeakPressure)
                pressurePeak = currentPressure;
        }
        private void UpdateDrop(double currentPressure)
        {
            double deltaP = pressurePeak - currentPressure;
            pressureDrop = deltaP > 0 ? deltaP : 0.0;
        }
        private void UpdateCycleTime(double stepTime) 
        {
            cycleTime += stepTime;
        }
        private void EvaluateCycleByPercent(double expectedDropPercentage) 
        {
            double dropPercentage = 100.0d * (1.0d - (pressurePeak - pressureDrop) / pressurePeak);

            pass = dropPercentage < expectedDropPercentage;
        }
        private void EvaluateCycleByValue(double expectedDrop) 
        {
            pass = pressureDrop < expectedDrop;
        }
    }
}
