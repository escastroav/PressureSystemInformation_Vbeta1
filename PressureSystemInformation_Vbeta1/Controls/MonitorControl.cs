using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PressureSystemInformation_Vbeta1.Visualization;
using PressureSystemInformation_Vbeta1.Test;

namespace PressureSystemInformation_Vbeta1.Controls
{
    public partial class MonitorControl : UserControl
    {
        private DigitalDisplay pressureDisplay;
        private DigitalDisplay dropDisplay;
        public MonitorControl()
        {
            InitializeComponent();
            pressureDisplay = new DigitalDisplay(PressureDisplayLabel, 20.0F);
            dropDisplay = new DigitalDisplay(DropDisplayLabel, 20.0F);
        }

        public void UpdateMonitor(LeakTest test, double input) 
        {
            pressureDisplay.UpdateDisplay(input);
            dropDisplay.UpdateDisplay(test.GetDropOfLastCycle());
        }

        private void MonitorControl_Load(object sender, EventArgs e)
        {
            pressureDisplay.InitializeDisplay(0.0);
            dropDisplay.InitializeDisplay(0.0);
        }
    }
}
