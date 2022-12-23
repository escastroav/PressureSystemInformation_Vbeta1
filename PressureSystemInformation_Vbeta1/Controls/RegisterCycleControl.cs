using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PressureSystemInformation_Vbeta1.Controls
{
    public partial class RegisterCycleControl : UserControl
    {
        public RegisterCycleControl()
        {
            InitializeComponent();
            FormatCycleTable();
        }

        public void FormatCycleTable() 
        {
            CyclesRegisterList.Columns["cycleID"].DefaultCellStyle.Format = "0000";
            CyclesRegisterList.Columns["startDate"].DefaultCellStyle.Format = "hh:mm:ss.f dd MMM yyyy";
            CyclesRegisterList.Columns["cycleTime"].DefaultCellStyle.Format = "0.0";
            CyclesRegisterList.Columns["pressurePeak"].DefaultCellStyle.Format = "F1";
            CyclesRegisterList.Columns["pressureDrop"].DefaultCellStyle.Format = "F1";
            
        }

        public DataGridView GetCycleList() => CyclesRegisterList;
    }
}
