using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PressureSystemInformation_Vbeta1.Controls
{
    public interface IStateHandlerControl
    {
        void DisableControl();
        void EnableControl();
    }
}
