using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PressureSystemInformation_Vbeta1.Fonts;
namespace PressureSystemInformation_Vbeta1.Visualization
{
    public class DigitalDisplay
    {
        private Label displayText;
        private CustomFont Ni7Seg;

        public DigitalDisplay(Label displayText, float fontSize)
        {
            this.displayText = displayText;
            Ni7Seg = new CustomFont();
            Ni7Seg.LoadFontInmemory(fontSize);
        }

        public void InitializeDisplay(double initValue) 
        {
            Ni7Seg.SetFontTo(displayText);
            displayText.Text = initValue.ToString("0000.0");
        }

        public void UpdateDisplay(double value) 
        {
            displayText.Invoke
                    ((MethodInvoker)
                         (() =>
                            displayText.Text = value.ToString("0000.0")
                         )) ;
        }


    }
}
