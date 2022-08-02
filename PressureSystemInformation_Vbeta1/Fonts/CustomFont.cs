using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing;

namespace PressureSystemInformation_Vbeta1.Fonts
{   
    public class CustomFont
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts;
        private Font myFont;

        public CustomFont()
        {
            this.fonts = new PrivateFontCollection();
        }

        public void LoadFontInmemory(float fontSize) 
        {
            byte[] fontData = Properties.Resources.ni7seg;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.ni7seg.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.ni7seg.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            myFont = new Font(fonts.Families[0], fontSize);
        }

        public void SetFontTo(Label label) 
        {
            label.Font = myFont;            
        }

    }
}
