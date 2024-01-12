using CHAOS.Som;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHAOS
{
    public partial class CSimulationManager
    {
        #region local data structures
        public BindingList<CSpaceshipHlaObject> Ships = new();
        public BindingList<CSpaceportHlaObject> Ports = new();
        #endregion

    }
}
