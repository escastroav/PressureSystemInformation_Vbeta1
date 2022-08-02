using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressureSystemInformation_Vbeta1.Test
{
    public class Calibration
    {
        private double maxPressure;
        public double MaxPressure { get { return maxPressure; } set { maxPressure = value; } }

        private double minPressure;
        public double MinPressure { get { return minPressure; } set { minPressure = value; } }

        private double maxVoltage;
        public double MaxVoltage { get { return maxVoltage; } set { maxVoltage = value; } }

        private double minVoltage;
        public double MinVoltage { get { return minVoltage; } set { minVoltage = value; } }

        public Calibration(double maxP, double minP, double maxV, double minV) 
        {
            maxPressure = maxP;
            minPressure = minP;
            maxVoltage = maxV;
            minVoltage = minV;
        }

        public double ConvertToPressure(int input) 
        {
            double digitalInput = input / 1023.0d;
            double electricInput = digitalInput * 5.0d;
            double normalizedInput = (electricInput - minVoltage) / (maxVoltage - minVoltage);
            double pressureInput = minPressure + normalizedInput * maxPressure;
            return pressureInput > 0 ? pressureInput : minPressure;
        }
    }
}
