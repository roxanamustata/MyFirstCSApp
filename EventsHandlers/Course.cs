using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHandlers
{
    public class Course:IEventTrigger
    {
        private DateTime dueDate;

        public Course(DateTime dueDate)
        {
            this.dueDate = dueDate;
        }


        public event EventHandler<StartDateEventArgs> OnStartDateChanged = delegate { };


        public DateTime StartDate
        {
            set
            {
                var startDate = value;
                if (startDate > dueDate)
                {
                    var startDateValue = new StartDateEventArgs
                    {
                        Value = startDate
                    };

                    OnStartDateChanged(this, startDateValue);
                }
            }



        }

        
    }
    }

