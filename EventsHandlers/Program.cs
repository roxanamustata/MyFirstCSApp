using System;

namespace EventsHandlers
{
    class Program
    {
        static void Main(string[] args)
        {
            IEventTrigger trigger = new Course(new DateTime(2021, 5, 1, 0, 0, 0));

            trigger.OnStartDateChanged += (o, e) => Console.WriteLine($"Announce all users about new start date: {e.Value}");
            trigger.StartDate = new DateTime(2021, 5, 2, 0, 0, 0);
        }
    }
}
