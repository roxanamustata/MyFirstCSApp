using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHandlers
{
    interface IEventTrigger

    {
        event EventHandler<StartDateEventArgs> OnStartDateChanged;
        DateTime StartDate { set; }
    }
}
