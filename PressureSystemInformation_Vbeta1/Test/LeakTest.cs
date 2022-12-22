using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PressureSystemInformation_Vbeta1.Controls;
namespace PressureSystemInformation_Vbeta1.Test
{
    public class LeakTest
    {
        private List<PressureAndTimeData> PTdata;
        private List<LeakCycle> cycles;
        private BindingSource cyclesBS;
        private DataGridView cyclesRegisterList;
        private Calibration calibrationPattern;

        public List<PressureAndTimeData> PTDataRep { get { return PTdata; } }
        public List<LeakCycle> cyclesRep { get { return cycles; } }
        
        private double mainPressurePeak;
        public double MainPressurePeak { get { return mainPressurePeak; } set { mainPressurePeak = value; } }

        private readonly DateTime startDate;
        public DateTime StartDate { get{ return startDate; } }

        private DateTime currentDate;
        public DateTime CurrentDate{ get{ return currentDate; } set { currentDate = value; } }

        private readonly double stepTime;
        public double StepTime { get{ return stepTime; } }

        private bool isRegisteringCycle;
        public bool IsRegisteringCycle{ get{ return isRegisteringCycle; } }
        public LeakTest(DateTime startDate, int SampleTime, DataGridView cyclesList, double maxP, double minP, double maxV, double minV) 
        {
            this.startDate = startDate;
            this.stepTime = SampleTime;
            this.cyclesRegisterList = cyclesList;
            cycles = new List<LeakCycle>();
            cycles.Clear();
            PTdata = new List<PressureAndTimeData>();
            PTdata.Clear();
            cyclesBS = new BindingSource { DataSource = cycles };
            cyclesRegisterList.DataSource = cycles;
            isRegisteringCycle = false;
            CreateCalibrationPattern(maxP, minP, maxV, minV);
        }
        private double GetPressure(int input) => calibrationPattern.ConvertToPressure(input);
        private double GetTime(int timeCount) => timeCount * stepTime * 0.001d;
        private void CreateCalibrationPattern(double maxP, double minP, double maxV, double minV) 
        {
            calibrationPattern = new Calibration(maxP, minP, maxV, minV);
        }
        public void AddPTData(int time, int pressure)
        {
            double t = GetTime(time); double P = GetPressure(pressure);
            PTdata.Add(new PressureAndTimeData(t, P));
            currentDate = DateTime.Now;
            if(PTdata.Count > 1)
                UpdatePeak();
        }
        public void RenderData(GraphControl graph, MonitorControl monitor) 
        {
            graph.UpdateGraph(PTdata.Last().TimeValue, PTdata.Last().PressureValue);
            monitor.UpdateMonitor(this,PTdata.Last().PressureValue);
        }
        public void UpdateCycle() 
        {
            cycles.Last().UpdateCycle(stepTime, PTdata.Last().PressureValue);
        }
        public int CyclesCount() { return cycles.Count; }
        public double GetDropOfLastCycle()         
        {            
            return cycles.Count > 0 ? cycles.Last().PressureDrop : 0;
        }
        public void StartNewCycle() 
        {
            isRegisteringCycle = true;
            cycles.Add(new LeakCycle(Convert.ToUInt32(cycles.Count), PTdata.Last().TimeValue, MainPressurePeak, currentDate));            
        }
        public void StopLastCycle(double expetedPercent, string type) 
        {
            isRegisteringCycle = false;
            
            cycles.Last().EndCycle(expetedPercent, type);         
            //cyclesBS.Add(cycles.Last());
            //cyclesRegisterList.DataSource = cyclesBS;
            cyclesRegisterList.Refresh();
        }       
        private void UpdatePeak() 
        {
            double currentP = PTdata[PTdata.Count - 1].PressureValue;
            double previousP = PTdata[PTdata.Count - 2].PressureValue;

            if (currentP > previousP)
                mainPressurePeak = currentP;
        }
        private double GetCurrentPressure() 
        {
            return PTdata.Last().PressureValue;
        }
    }
}
