using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressureSystemInformation_Vbeta1.Test
{
    public class PressureAndTimeData
    {
        private readonly double pressureValue;
        public double PressureValue { get{ return pressureValue; } }

        private readonly double timeValue;
        public double TimeValue{ get{ return timeValue; } }

        public PressureAndTimeData(double time, double pressure) 
        {
            timeValue = time;
            pressureValue = pressure;
        }


    }
}
