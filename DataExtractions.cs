using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortolketOpgave
{
    class DataExtractions
    {
        public List<Browsers> Browser { get; set; }
        public Connections Connection { get; set; }
        public List<Programs> Program { get; set; }
        public OperatingSystems OperatingSystem { get; set; }
        public Quantity Quantity { get; set; }

    }
}
