﻿using System;
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
        }

        public DataGridView GetCycleList() => CyclesRegisterList;
    }
}
