using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHandlers
{
    public class StartDateEventArgs:EventArgs
    {
        public DateTime Value { get; set; }
    }
}
